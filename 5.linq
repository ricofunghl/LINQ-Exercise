<Query Kind="Expression">
  <Connection>
    <ID>85e0ca4f-127f-49f2-9ca7-6bf543d98408</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>

from x in Shifts
where x.PlacementContract.Location.Name.Contains("NAIT")
orderby x.DayOfWeek ascending
group x by x.DayOfWeek into result
select new {
	DayOfWeek = result.Key,
	EmployeesNeeded = result.NumberOfEmployees
					
}
