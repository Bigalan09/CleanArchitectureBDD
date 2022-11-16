Feature: ShoppingBasket

A shopping basket allows products to be collected, ready for checkout.

Scenario: Initially the shopping basket should be empty
	When I enter the shop
	Then my shopping basket should be empty
