import * as THREE from 'https://cdn.jsdelivr.net/npm/three@0.118/build/three.module.js';
//import {FBXLoader} from 'https://cdn.jsdelivr.net/npm/three@0.118.1/examples/jsm/loaders/FBXLoader.js';
import { GLTFLoader } from 'https://cdn.jsdelivr.net/npm/three@0.118.1/examples/jsm/loaders/GLTFLoader.js';
import { OrbitControls } from 'https://cdn.jsdelivr.net/npm/three@0.118/examples/jsm/controls/OrbitControls.js';
import { RGBELoader } from 'https://cdn.jsdelivr.net/npm/three@0.116.1/examples/jsm/loaders/RGBELoader.js';
//import { RoughnessMipmapper } from 'https://cdn.jsdelivr.net/npm/three@0.116.1/examples/jsm/utils/RoughnessMipmapper.js';


export function AnimoLoader() {

	var loader = new GLTFLoader();
	var scene = new THREE.Scene();

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
			loader.load('./3d/models/PolyWorld.gltf', function (gltf) {
				scene.add(gltf.scene);		


				const model = gltf.scene;
				//model.position.set(1, .75, 0);
				model.scale.set(1.2, 1.2, 1.2);
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

	function render() {
		renderer.render(scene, camera)
	}

	animate();

    
}