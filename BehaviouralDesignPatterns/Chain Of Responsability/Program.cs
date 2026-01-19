using Chain_Of_Responsability.WorkFlow;

namespace Chain_Of_Responsability
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Emp = new Employee()
            {
                id = 1,
                Name = "sampo",
                JobTitle= JobTitle.Developer,
            };
            var vacation = new VacationRequest()
            {
                Employee = Emp,
                StartDate = DateTime.Now.AddDays(1),
                EndDate = DateTime.Now.AddDays(2)
            };

            TeamLeaderApproveHandler teamLeaderApproveHandler = new TeamLeaderApproveHandler();
            TechnicalMangerApproveHandler technicalMangerApproveHandler = new TechnicalMangerApproveHandler();
            CTOApproveHandler cTOApproveHandler = new CTOApproveHandler();  
            CEOApproveHandler cEOApproveHandler = new CEOApproveHandler();
            ValidationApproveHandler validationApproveHandler = new ValidationApproveHandler();

            validationApproveHandler.SetNext(teamLeaderApproveHandler);
            teamLeaderApproveHandler.SetNext(technicalMangerApproveHandler);
            technicalMangerApproveHandler.SetNext(cTOApproveHandler);
            cTOApproveHandler.SetNext(cEOApproveHandler);

            validationApproveHandler.process(vacation);






        }
    }
}
