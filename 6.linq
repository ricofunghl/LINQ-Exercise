<Query Kind="Expression">
  <Connection>
    <ID>85e0ca4f-127f-49f2-9ca7-6bf543d98408</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>

from x in EmployeeSkills
select x.YearsOfExperience.Sum(y >= y.YearsOfExperience).Max()