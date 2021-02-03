namespace Model.Shared
{
    public class ProjectTecnos
    {
        
        public int ProjectId { get; set; }
        public int TecnoId { get; set; }
        public int Order { get; set; }
        public Projects Project { get; set; } 
        public Tecnos Tecno { get; set; } 
         
    }
}
