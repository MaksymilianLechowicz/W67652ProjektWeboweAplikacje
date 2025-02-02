
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace W67652MaksymilianLechowiczProjektZAplikacjiWebowych.Entity { 
[Table("Plant", Schema = "Cross")]
    public class Plant : BaseEntity
    {
        public Plant()
        {
            
        }
        public Plant(string plantName, string filename)
        {
            PlantName = plantName;
            FileNameForImage = filename;
        }
        
        [Required]
        public string PlantName { get; set; }

        public string FileNameForImage { get; set; }

    }

}
