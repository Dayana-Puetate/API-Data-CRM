namespace API_Data_CRM.Models.Data
{
    public class ResponseModel<T>
    {
        public IEnumerable<T> Data { get; set; }
        public ErrorlModel Error { get; set; }
    }

    public class ErrorlModel
    {
        public int CodigoError { get; set;}
        public string MensajeError { get; set; }
    }
}


/*
 namespace API_Data_CRM.Models.Data
{
    public class ResponseModel<T>
    {
        public T Data { get; set; }
        public ErrorlModel Error { get; set; }
    }

    public class ErrorlModel
    {
        public int CodigoError { get; set;}
        public string MensajeError { get; set; }
    }
}

 */

