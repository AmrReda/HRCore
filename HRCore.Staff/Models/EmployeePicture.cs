namespace HRCore.Staff.Models
{
    public class EmployeePicture
    {
        public int EmployeePictureId { get; set; }
        public int PictureType { get; set; }
        public byte[] Content { get; set; }
        public int EmployeeId { get; set; }
        public int? CropTop { get; set; }
        public int? CropBottom { get; set; }
        public int? CropLeft { get; set; }
        public int? CropRight { get; set; }
        public int? CropWidth { get; set; }
        public int? CropHeight { get; set; }

        public virtual Employee Employee { get; set; }
    }
}