<p align="center">
	<a href="https://github.com/GwGibson/IOT1026-Assignment-3/actions/workflows/ci.yml">
    <img src="https://github.com/GwGibson/IOT1026-Assignment-3/actions/workflows/ci.yml/badge.svg"/>
    </a>
	<a href="https://github.com/GwGibson/IOT1026-Assignment-3/actions/workflows/formatting.yml">
    <img src="https://github.com/GwGibson/IOT1026-Assignment-3/actions/workflows/formatting.yml/badge.svg"/>
	<br/>
    <a href="https://codecov.io/gh/GwGibson/IOT1026-Assignment-3" > 
    <img src="https://codecov.io/gh/GwGibson/IOT1026-Assignment-3/branch/main/graph/badge.svg?token=JS0857X5JD"/> 
	<img title="MIT License" alt="license" src="https://img.shields.io/badge/license-MIT-informational?style=flat-square">	
    </a>
</p>        
        
# IOT1026-Assignment-3
        
The project is a console application that simulates a pack or backpack used for storing various inventory items. It consists of three classes: InventoryItem, Pack, and PackTester.

The InventoryItem class represents an item with properties such as name, weight, and volume.

The Pack class represents the pack or backpack, which has a maximum count of items it can hold, maximum volume, and maximum weight. It provides methods to add items to the pack and calculates the total weight and volume of the items in the pack.

The PackTester class provides a console-based user interface for testing and interacting with the pack. It allows the user to choose items from a list and adds them to the pack. It displays the current contents of the pack and informs the user if an item cannot be added due to pack constraints.

The Program class serves as the entry point of the application, creating an instance of the pack and calling the AddEquipment method of the PackTester class to start the interaction with the pack.

The project also includes unit tests using MSTest framework to verify the functionality of the Pack class. The tests check if items can be added to the pack within the specified constraints and validate the behavior of the pack when adding items.
        
![image](https://github.com/diljitehg/IOT1026-Assignment-3/assets/131228332/c4b8e28c-2501-4ccf-86c5-6f5a108234ec)
        
        
[Assignment Instructions](docs/instructions.md)  
[How to start coding](docs/how-to-use.md)  
[How to update status badges](docs/how-to-update-badges.md)
