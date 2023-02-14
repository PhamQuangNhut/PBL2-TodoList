namespace TodoList
{
    [Serializable]
    public class PlanData
    {
        private List<TodoItem> taskList;

        public List<TodoItem> TaskList { get => taskList; set => taskList = value; }

    }
}
