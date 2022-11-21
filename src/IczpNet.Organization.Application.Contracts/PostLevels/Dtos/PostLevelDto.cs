using IczpNet.Organization.BaseDtos;

namespace IczpNet.Organization.PostLevels.Dtos
{
    public class PostLevelDto : BaseDto
    {
        //[Range(0, 20)]
        public virtual long Value { get; set; }

        public virtual int PostGradeCount { get; set; }
    }
}
