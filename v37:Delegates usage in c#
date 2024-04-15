namespace v37
{
    internal class Program
    {
        public delegate void EmployeeTask(string taskDescription); // Delegate for employee tasks

        class JuniorEmployee
        {
            public void ReviewReport(string report)
            {
                Console.WriteLine("Junior employee reviewing report: {0}", report);
            }
        }

        class SeniorEmployee
        {
            public void ApproveLeaveRequest(string request)
            {
                Console.WriteLine("Senior employee approving leave request: {0}", request);
            }
        }

        static void Main(string[] args)
        {
            JuniorEmployee junior = new JuniorEmployee();
            SeniorEmployee senior = new SeniorEmployee();

            // Delegate assignment based on task type
            EmployeeTask task;
            string taskType = "Review Report"; // Change this to "Approve Leave Request" for testing

            if (taskType == "Review Report")
            {
                task = junior.ReviewReport; // Assign Junior's method for report review
            }
            else if (taskType == "Approve Leave Request")
            {
                task = senior.ApproveLeaveRequest; // Assign Senior's method for leave approval
            }
            else
            {
                Console.WriteLine("Invalid task type!");
                return; // Exit if task type is invalid
            }

            // Invoke delegate based on assigned task
            task("This is the task description"); // Replace with actual task description
        }

    }
}
