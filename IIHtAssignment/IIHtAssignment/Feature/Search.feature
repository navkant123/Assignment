Feature: SearchFlight
  As a user i will be able to search the flight
  Background:
  Given Navigate to the site URL
 

@flight
Scenario: Search flight on AirAsia
	When Verify the title
	And  enter origin as "Begaluru"
	And enter  destination as "Pune"
	When select the depart date as "June 2021"
   Then Verify the flight page