<Query Kind="Expression">
  <Connection>
    <ID>85e0ca4f-127f-49f2-9ca7-6bf543d98408</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>

from x in Skills
where x.RequiresTicket == true
select new {
	Description = x.Description,
	Employees = from y in x.EmployeeSkills
				orderby y.YearsOfExperience descending
				select new {
				Name = y.Employee.FirstName + " " +  y.Employee.LastName,
				Level = y.Level == 1?"Novice"
									:y.Level == 2? "Proficient":"Expert",
				YearsExpereicne = y.YearsOfExperience
				}
}