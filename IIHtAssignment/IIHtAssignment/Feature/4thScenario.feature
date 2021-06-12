Feature: 4thScenario
	As a user should be able to successfully registered 

@automation practice
Scenario:Register on AutomationPractice site
	Given Navigate to the Home Page
	And Click on SignIn Button
	And Pass a Valid <Email>
	When Click on Register link
	And Validate you are on regeter page
	And Select the title Radio box
	When User Enter <FirstName>,<LastName> and <Password>
	And Select Date,month nad yearofbirth
	And Enter <Address>,<City>
	And Select State
	And enter <PostalCode>, <MobileNumber>
	When User click on Register buttton
	Then Validate you have succesfully Registerd

Examples:
| Email                   | FirstName | LastName | Password    | Address     | City       | PostalCode | MobileNumber |
| navkantraj1990@gmal.com | Navkant   | Yadav    | Iiht@1234   | Madhuba   | Madhubani1  | 99505     | 7808170912   | 
| navkantraj1991@gmail.com | Mohini    | Mishra   | Iiht@12345  | Madhubani1234 | Madhubani1789 | 99506     | 7807808174   |   
| nida.afreen2@iiht.com    | Nida      | Afreen   | Iiht@123456 | Madhubani2678 | Madhubani23477 | 99507     | 7808270911   |
	