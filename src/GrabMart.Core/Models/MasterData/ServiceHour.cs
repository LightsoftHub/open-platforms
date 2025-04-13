using Light.GrabMart.Models.Common;

namespace Light.GrabMart.Models.MasterData
{
    /// <summary>
    /// Use for Menu
    /// </summary>
    public class ServiceHour
    {
        public virtual ServiceHourPeriod Mon { get; set; }
        public virtual ServiceHourPeriod Tue { get; set; }
        public virtual ServiceHourPeriod Wed { get; set; }
        public virtual ServiceHourPeriod Thu { get; set; }
        public virtual ServiceHourPeriod Fri { get; set; }
        public virtual ServiceHourPeriod Sat { get; set; }
        public virtual ServiceHourPeriod Sun { get; set; }
    }
}
