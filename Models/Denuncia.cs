namespace Linea_Denuncia_API.Models
{
    public class Denuncia
    {
        public int Id { get; set; }
        public int EO_Id { get; set; }
        public int Country_id { get; set; }
        public int State_id { get; set; }    
        public string Anonim { get; set; }
        public string Complete_Name { get; set; }
        public string Email { get; set; }   
        public string Phone { get; set; }
        public string Folio { get; set; }
        public DateTime Create_Date { get; set; }
        public string User_Password { get; set; }
        public string Detalle { get; set; }



    }
}
