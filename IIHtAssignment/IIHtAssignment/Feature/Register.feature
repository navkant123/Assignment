Feature: Register
	Asa user should be able to register with valid details

@travel
Scenario: Register User With Data
	Given Navigate to Homepage
	And Click on Register link
	When User enter <FirstName>,<LastName>,<Phone>,<Email>,<Address>,<City>,<State>,<PostalCode>
	And Select the country
	And enter <UserName>,<PassWord>
	Then Click On submit button

	Examples:
	| FirstName | LastName | Phone      | Email                    | Address | City      | State | PostalCode | UserName | PassWord      | ConformPassWord |
	| Navkant   | Yadav    | 7808170913 | navkantraj1997@gmail.com | Olipur  | Madhubani | Bihar | 847403     | Navi0123 | Password@1234 | Password@1234   |
	| Navi      | Kumar    | 7808170913 | navkantraj1997@gmail.com | Olipur  | Madhubani | Bihar | 847403     | Navi0123 | Password@1234 | Password@1234   |
	| Mounika   | Yadav    | 7808170913 | navkantraj1997@gmail.com | Olipur  | Madhubani | Bihar | 847403     | Navi0123 | Password@1234 | Password@1234   |
	| Rava      | Yadav    | 7808170913 | navkantraj1997@gmail.com | Olipur  | Madhubani | Bihar | 847403     | Navi0123 | Password@1234 | Password@1234   |
	| Aparna    | Yadav    | 7808170913 | navkantraj1997@gmail.com | Olipur  | Madhubani | Bihar | 847403     | Navi0123 | Password@1234 | Password@1234   |
	| Choubey   | Yadav    | 7808170913 | navkantraj1997@gmail.com | Olipur  | Madhubani | Bihar | 847403     | Navi0123 | Password@1234 | Password@1234   |
	| Nida      | Yadav    | 7808170913 | navkantraj1997@gmail.com | Olipur  | Madhubani | Bihar | 847403     | Navi0123 | Password@1234 | Password@1234   |
	|Affreen    | Yadav    | 7808170913 | navkantraj1997@gmail.com | Olipur  | Madhubani | Bihar | 847403     | Navi0123 | Password@1234 | Password@1234   |
    | Anil      | Yadav    | 7808170913 | navkantraj1997@gmail.com | Olipur  | Madhubani | Bihar | 847403     | Navi0123 | Password@1234 | Password@1234   |
	| Nav       | Yadav    | 7808170913 | navkantraj1997@gmail.com | Olipur  | Madhubani | Bihar | 847403     | Navi0123 | Password@1234 | Password@1234   |