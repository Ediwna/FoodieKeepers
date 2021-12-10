# FoodieKeepers
![](https://github.com/Ediwna/FoodieKeepers/blob/main/rec/wasteFood.jpg)  
App that allows restaurants, hypermarkets...to sell their food leftovers of the day at a cheaper price to customer in order to avoid food wasting.

## Hanyang Unversity Software Engineering project
### Quick links
GUI mockups [proto.io](https://pr.to/UODON0/) <br>
Youtube demo [demoVideo](https://youtu.be/zZdBhHHDMr8)

## Contributors
* Yeol Yang，Hanyang University，yeolyang77@gmail.com  
* Daphnée Correia，Hanyang University，daphnee.correia@edu.devinci.fr  
* Edouard Maurice Hanyang University，edouard.maurice@edu.devinci.fr  
* Pacôme Manceaux Hanyang University，pacome.manceaux@gmail.com  

## I Introduction
### A. Abstract
As our society is getting more concerned about inequalities, we are suggesting a way to end bad alimentation. Because of bad financial situation, a lot of people have to skip meals or use cheap junk food. To answer this issue, our project aims on giving cheap but better food to these people. Furthermore, our solution is ecological and avoid the food to go to waste. Our project is an app that links the restaurant’s owners with customers with financial issues. Our app will inform its users when a restaurant nearby has food leftovers. Index Terms—Food, Online service, Application  <br>

### B. Motivation
The unfinished meals after a grand party or activity, the food that cannot be sold in restaurants and snack stalls every day, or the goods to be eliminated after the supermarket’s daily inventory are mainly still edible and intact food, but have to be discarded as garbage. Accorded to the United Nations, one third of the world’s food is discarded, and the main cause of waste is expired or poorly sold goods from large supermarkets all over the world. Discarded food is certainly a loss, but for businesses, it is the choice to maximize benefits to quickly empty inventory and quickly replace foods. In this world of hyper-consumption, we wanted to give a slight inflection, a small deviation just above the minimum to perhaps participate in a change of our ways of thinking. Let's use this opportunity of premature waste in our nearest shops to introduce a new system of social sharing.

### C. Research on any related software
  * [Olio](https://olioex.com/) Olio is a mobile app for food-sharing, aiming to reduce food waste. It does this by connecting those with surplus food to those who need or wish to consume such food. The food must be edible; it can be raw or cooked, sealed or open. <br>
  * [Too good to go](https://toogoodtogo.org/en) Too Good To Go is a mobile application that connects customers to restaurants and stores that have unsold food surplus. <br>
  * [Phenix](https://phenixbyonthelist.com/zh/) Phenix mobile app gives you the chance to put an end to food waste and buy food at a discounted price from our trusted partners. <br>
  * [No food waste](https://nofoodwaste.org/)No Food Waste is a movement turned NGO started by Padmanaban Gopalan and his friends Dinesh manickam and Sudhakar Mohan to get rid of the problem of hunger. <br>

## II Development envrionment 
Main language -- `C#` & `XAML` <br>
Coding envrionment -- `Microsoft Visual Studio` <br>
Main platform -- `Android applicatopn` <br>
Database -- `Firebase` <br>

## III Specifications
### A. Creating an account
The user is provided with two choices: `log-in` or `create an account`.  <br>
<img src= "https://github.com/Ediwna/FoodieKeepers/blob/main/rec/signin_login.png" width="200" height="500" alt="sign in & login page"/>

After clicking on this button, the user will be moved to another page which will let him choose if he wants to buy or sell products on the app. <br>
![](https://github.com/Ediwna/FoodieKeepers/blob/main/rec/buyer_seller.png)

#### Buyer side
By clicking to the “I want to buy” button, the user will be led to another page which will allow him to fill his personal information. <br>
![](https://github.com/Ediwna/FoodieKeepers/blob/main/rec/buyer_fill_info.png) <br>
And to verify the entered information to avoid typing errors when filling the mail address and the phone number. <br>
![](https://github.com/Ediwna/FoodieKeepers/blob/main/rec/buyer_verification.png)<br>
Finally, the user will have to fill one last step. He will have to choose his favorite kinds of food amongst the proposed selection. <br>
![](https://github.com/Ediwna/FoodieKeepers/blob/main/rec/buyer_select.png)

#### Seller side
By clicking on the “I want to sell” button, the user will be led to the seller part of the application. The first steps of the registration are similar to the buyer side registration. <br>
![](https://github.com/Ediwna/FoodieKeepers/blob/main/rec/seller_fill_info.png)<br>
![](https://github.com/Ediwna/FoodieKeepers/blob/main/rec/seller_fill_info2.png)

### B. Making and track an order
After having created an account or signed up if the user already had an account, he will be redirected to the main page of the application. In this main page, different sections will be displayed. <br>
The first section is divided into several categories which will help the user choose where and what to order. <br>
First category is “Type of food”. By clicking on it, the user will be redirected to a page listing the different kinds of food available. Then the user will click on what he wants to try and a list of restaurants serving this type of food will be displayed. The list will be sorted regarding the user’s location to be more convenient and avoid proposing restaurants located too far. <br>
The second category is “Around me”. This category will open a map showing all the restaurants proposing leftovers around the user’s position.<br>
The third one is “Short in time” category. This one will show the user the restaurants with the shortest pick-up time so that the user can enjoy a meal fast if he has a sudden craving or needs to eat fast to go back to work for example.<br>
The fourth category is “Grocery shopping”. Clicking on this category will allow the user to see which store offers food items around him. <br>
Last category is for those who are tired of eating the same thing and want to experience something new. The “Mystery choice” category will propose a restaurant to the user. The selection criteria will be the user’s position (it is important to not be too far, for the same reasons as mentioned above), the user’s preferences filled during the creation of his account and his former orders to avoid suggesting something he has already tried. <br>
![](https://github.com/Ediwna/FoodieKeepers/blob/main/rec/category.png) <br>

There is also a sliding menu on the top left of the screen. This menu has three categories: “My account”, “Order history”, “Log out”.
The “My account” section will allow the user to modify the information he has previously filled. He will also be able to register a credit card for the payment of his future orders. The “Order history” section will provide the user a summary of all the orders he has made, with the restaurant’s name, the items purchased, the price, the date of the purchase…Finally, the “Log out” section will allow the user to disconnect from his account.<br>
![](https://github.com/Ediwna/FoodieKeepers/blob/main/rec/account.png) <br>

## IV Methodology

