import * as THREE from 'https://cdn.jsdelivr.net/npm/three@0.118/build/three.module.js';
//import {FBXLoader} from 'https://cdn.jsdelivr.net/npm/three@0.118.1/examples/jsm/loaders/FBXLoader.js';
import { GLTFLoader } from 'https://cdn.jsdelivr.net/npm/three@0.118.1/examples/jsm/loaders/GLTFLoader.js';
import { OrbitControls } from 'https://cdn.jsdelivr.net/npm/three@0.118/examples/jsm/controls/OrbitControls.js';
import { RGBELoader } from 'https://cdn.jsdelivr.net/npm/three@0.116.1/examples/jsm/loaders/RGBELoader.js';
//import { RoughnessMipmapper } from 'https://cdn.jsdelivr.net/npm/three@0.116.1/examples/jsm/utils/RoughnessMipmapper.js';
import Bowser from './browser_detect_library/bowser.js';

export function AnimoLoader() {

	let mixer, aspect;
	let clock = new THREE.Clock();
	var loader = new GLTFLoader();
	var scene = new THREE.Scene();
	//variables for tracking scroll and syncing timeline
	let scrollBuffer = 0;
	let currentScroll = 0;
	let scrollDelta = 0;
	let el;
	//brower detect for balancing scroll speed
	const browserName = Bowser.parse(window.navigator.userAgent).browser.name;
// console.log(browserName);
	//overall scroll speed factor
	const scrollSpeed = 10;
	//variables for restricting animation to frame range,
	//and for unhiding divs at appropriate frames
	let currentAnimationFrame, currentTime = 0;
	//hidden divs, variables for click handling of buttons
	let firstHiddenDiv, secondHiddenDiv, thirdHiddenDiv;
	let firstHiddenButton, secondHiddenButton, thirdHiddenButton;


	var light = new THREE.SpotLight();
	light.position.set(5, 5, 5)
	scene.add(light);

	var light2 = new THREE.SpotLight();
	light.position.set(50, 5, -50)
	scene.add(light2);

	var light3 = new THREE.SpotLight();
	light.position.set(5, 50, 50)
	scene.add(light3);

	const lightAmbient = new THREE.AmbientLight(0x404040); // soft white light
	scene.add(lightAmbient);

	var camera = new THREE.PerspectiveCamera(75, window.innerWidth / window.innerHeight);
	camera.position.set(-10, 10, 0);


	var renderer = new THREE.WebGLRenderer({ antialias: true, alpha: true });
	renderer.toneMapping = THREE.ACESFilmicToneMapping;
	renderer.toneMappingExposure = 1;
	renderer.outputEncoding = THREE.sRGBEncoding;
	renderer.setSize(window.innerWidth, window.innerHeight);

	renderer.toneMapping = THREE.ACESFilmicToneMapping;
	renderer.toneMappingExposure = 1;
	renderer.outputEncoding = THREE.sRGBEncoding;


	
	window.addEventListener('resize', onWindowResize, false);
	// HDRI

	new RGBELoader()
		.setDataType(THREE.UnsignedByteType)
		.setPath('./3d/models/')
		.load('versionhdr.hdr', function (texture) {

			const envMap = pmremGenerator.fromEquirectangular(texture).texture;

			//scene.background = envMap; // escondo el hdri
			scene.environment = envMap;

			texture.dispose();
			pmremGenerator.dispose();

			render();

			// model			
			loader.load('./3d/models/scene.gltf', function (gltf) {
				scene.add(gltf.scene);		


				const model = gltf.scene;
				//model.position.set(1, .75, 0);
				model.scale.set(1.2, 1.2, 1.2);

				mixer = new THREE.AnimationMixer(model);
				mixer.clipAction(gltf.animations[0]).play();

				roughnessMipmapper.dispose();

				render();
			});
		});



	const pmremGenerator = new THREE.PMREMGenerator(renderer);
	pmremGenerator.compileEquirectangularShader();
	// end HDRI
		
	let elem = document.getElementById('topThree');
	elem.appendChild(renderer.domElement);
	//renderer.setSize(window.innerWidth, window.innerHeight);
	//document.body.appendChild(renderer.domElement);

	const controls = new OrbitControls(camera, renderer.domElement)
	controls.enableZoom = false;
	controls.autoRotate = true;

	//loader.load('./3d/models/AnimoGLTF.gltf',
 //       function (gltf) { 
 //           scene.add(gltf.scene);
 //       },(xhr) => {console.log((xhr.loaded / xhr.total * 100) + '% loaded')},
 //       (error) => {console.log(error);}
 //   );

	var animate = function () {
		requestAnimationFrame(animate);	
		controls.update();
		render();	
	};

	//function render() {
	//	renderer.render(scene, camera)
	//}
	function render() {// refresh view/re-render canvas

		scrollDelta = currentScroll - scrollBuffer;
		if (browserName === "Chrome" || browserName === "Microsoft Edge") { scrollDelta *= 0.03; }
		requestAnimationFrame(render);
		var delta = clock.getDelta();

		let updateBuffer = delta * scrollDelta * 20 * scrollSpeed;

		if (mixer != null) {

			//restrict animation to 0.11s - 22.9s (24FPS)
			if (currentTime > 22.9) { currentTime = 22.9; }
			if (currentTime < 0.11) { currentTime = 0.11; }

			currentTime = currentTime + updateBuffer;
			if (currentTime >= 0.11 && currentTime < 22.9) {
				//do something if animation is within restricted range
				currentTime
			} else {
				//don't play animation
				updateBuffer = 0;
			}

			//sync animation time with scroll position
			mixer.update(updateBuffer);
			scrollBuffer = currentScroll;

			currentAnimationFrame = mixer.time * 24;

			//hide or unhide clickable divs based on current frame
			//if (currentAnimationFrame > 58 && firstHiddenDiv) {
			//	firstHiddenDiv.classList.add('active-div');
			//}

			//if (currentAnimationFrame > 75 || currentAnimationFrame < 58) {
			//	firstHiddenDiv.classList.remove('active-div');
			//}


			//if (currentAnimationFrame > 268 && secondHiddenDiv) {
			//	secondHiddenDiv.classList.add('active-div');
			//}

			//if (currentAnimationFrame > 284 || currentAnimationFrame < 268) {
			//	secondHiddenDiv.classList.remove('active-div');
			//}


			//if (currentAnimationFrame > 480 && thirdHiddenDiv) {
			//	thirdHiddenDiv.classList.add('active-div');
			//}

			//if (currentAnimationFrame > 494 || currentAnimationFrame < 480) {
			//	thirdHiddenDiv.classList.remove('active-div');
			//}

		};

		renderer.render(scene, camera);

	}

	function onWindowResize() { //make canvas responsive
		camera.aspect = window.innerWidth / window.innerHeight;
		aspect = camera.aspect;
		camera.updateProjectionMatrix();
		renderer.setSize(window.innerWidth, window.innerHeight);
		render();

	}
	//event functions
	function zoom(event) {
		event.preventDefault();
		currentScroll += event.deltaY * -0.01;
	}

	function firstButtonClick() {
		window.open('https://www.google.com/');
	}
	function secondButtonClick() {
		window.open('https://www.amazon.com/');
	}
	function thirdButtonClick() {
		window.open('https://www.duckduckgo.com/');
	}

//event listeners
//el.onwheel = zoom;
//firstHiddenButton.addEventListener('click', firstButtonClick);
//secondHiddenButton.addEventListener('click', secondButtonClick);
//thirdHiddenButton.addEventListener('click', thirdButtonClick);

	animate();

    
}