namespace TailSpin.SpaceGame.Web.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        //stage
        //CR-2

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}