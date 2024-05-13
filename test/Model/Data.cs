using System;

namespace k11
{
    public enum UserType
    {
        TaskPerformer, 
        TaskCreator
    }
    public class PersonData
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Postname { get; set; }

        public UserType UserType { get; set; }
    }

    public class TaskData
    {
        public Guid TaskId { get; set; }
        public string TaskTitle { get; set; }
        public string TaskDescription { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsImportant { get; set; }


        public Guid UserId { get; set; }
        public PersonData PersonData { get; set; }
    }
}
