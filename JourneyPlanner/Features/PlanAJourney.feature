Feature: PlanAJourney
 As a user
 I want to navigate to TFL plan journey
 To plan my journey using journey planner widgets

 Background: 
    Given I navigate to Tfl website "https://tfl.gov.uk"
	When I click on cookies button
	Then plan a journey page is displayed

	
     
Scenario Outline: Verify that a valid journey can be planned using the widget
	When I enter from a location "<From Location>"
	And I enter to a location "<To Location>"
	And I click change time link
	Then I verify that leaving tab is enabled
	When I select leaving date 
	And I select leaving time
	And I click plan my journey
	Then quieter Times Message Displayed

	
	
Examples: 
	| From Location | To Location |
	  
	| SS16 5XY      | EC3M 4AJ    |

Scenario Outline: Verify that the widget is unable to provide results when an invalid journey is planned using wrong location
   	When I enter from a location "<From Location>"
	And I enter to a location "<To Location>"
	And I click change time link
	Then I verify that leaving tab is enabled
	When I select leaving date 
	And I select leaving time
	And I click plan my journey
	Then journey results is displayed
	And error "<message>" will be displayed

	Examples: 
	| From Location | To Location | message                                                                     |
	| Southampham  | SO17 1BJ   | Journey planner could not find any results to your search. Please try again |
	| SO17 1BJ      | SO15 5BJ    | Journey planner could not find any results to your search. Please try again |
	                 
	
Scenario Outline: Verify that the widget is unable to plan a journey if no locations are entered into the widget. 
     When I click change time link
     Then I verify that leaving tab is enabled
	 When I select leaving date 
	 And I select leaving time
	 And I click plan my journey
	 Then "<fromFieldError>" and "<toFieldError>" messages displayed

	 Examples: 
	 | fromFieldError              | oFieldError               |
	 | The From field is required. | The To field is required. |
	 
Scenario: Verify change time link on the journey planner displays “Arriving” option and plan a journey based on arrival time
    When I enter from a location "E6 2AS "
    And I enter to a location "IG1 2JJ"
    And I click change time link
    Then I verify that leaving tab is enabled	
	When I click arriving tab
	Then I verify that arriving tab is enabled
	When I select arriving date 
	And I select arriving time
	And I click plan my journey
	Then journey results is displayed
	And quieter Times Message Displayed
	

Scenario: On the Journey results page, verify that a journey can be amended by using the “Edit Journey” button.
    When I enter from a location "Basildon Rail station"
	And I enter to a location "Fenchurch rail station"
	And I click change time link
	Then I verify that leaving tab is enabled
	When I select leaving date 
	And I select leaving time 
	And I click plan my journey
	When I click edit journey
	And I enter from a location "SS14 2EJ"
	And I enter to a location "TW3 3TL"
	When I select leaving date 
	And I select leaving time
	And I click update journey
	Then journey results is displayed


Scenario: Verify that the “Recents” tab on the widget displays a list of recently planned journeys. (Note: This will only happen if all cookies are enabled).
    When I enter from a location "RM6 6NB"
	And I enter to a location "EC3P 3DQ"
	And I click change time link
	Then I verify that leaving tab is enabled
	When I select leaving date 
	And I select leaving time
	And I click plan my journey
	Then journey results is displayed
	When I click on home
	And I click on New tab
	When I enter from a location "E15 3BW"
	And I enter to a location "IG1 2JJ"
	And I click change time link
	When I select leaving date 
	And I select leaving time
	And I click plan my journey
	Then journey results is displayed
	When I click on home	
	And I click recents tab on the widget
	Then  a list of recently planned journeys displayed 
	
	
	                 

	



