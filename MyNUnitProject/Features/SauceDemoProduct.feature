Feature: SauceDemoProduct

Background:
  Given the user is on login page
  When the user enters the correct credentials
  Then the user enters into product dashboard

Scenario: Put product into add to cart
When the user should select required product
Then the user be on the specific product page