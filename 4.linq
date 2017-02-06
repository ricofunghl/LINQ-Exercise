<Query Kind="Expression">
  <Connection>
    <ID>85e0ca4f-127f-49f2-9ca7-6bf543d98408</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>

from x in Employees
where x.EmployeeSkills.Count() > 1
select new {
	Name = x.FirstName + " " + x.LastName,
	Skills = from y in x.EmployeeSkills
			select new {
				Description = y.Skill.Description,
				Level = y.Level == 1?"Novice"
									:y.Level == 2? "Proficient":"Expert",
				YearsExperience = y.YearsOfExperience
			}
}
