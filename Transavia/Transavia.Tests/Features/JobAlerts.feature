Feature: Job Alerts

    Scenario: TC01 - Subscribe for Job Alert at WerkenbijTransavia
        Given I am on https://werkenbijtransavia.com
        When I click on vakgebied Cabine
        Then I should see the url https://werkenbijtransavia.com/cabin-attendant
        When I click on the aanmelden jobalert button
        Then I should see the Aanmelden Jobalerts page
        When I fill in my email address with Test@TransaviaTest.nl
        And I set my Voorkeursafdeling to IT
        And I set my Voorkeurstaal to English
        And I set Hoe vaak wil je vacaturemeldingen ontvangen to wekelijks
        And I check the box Ik ga akkoord emails van Transavia te ontvangen
        Then I should see the button Aanmelden