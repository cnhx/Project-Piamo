q
ORK Framework
http://orkframework.com


-------------------------------------------------------------------------------------------------------------------------------------------------------
Content
-------------------------------------------------------------------------------------------------------------------------------------------------------

- General Information
- Editor and Scene Wizard
- Tutorials
- Support
- Documentation
- Demo
- Package Description
- iOS Hints
- ORK Version Changelog



-------------------------------------------------------------------------------------------------------------------------------------------------------
General Information
-------------------------------------------------------------------------------------------------------------------------------------------------------

- DLL information
ORK Framework is included in your Unity project using DLLs.
This will dramatically increase your project's compile time if you change any of your own scripts.
The source code for gameplay related code is included - see the 'Package Description' section for details.

- ORK Project asset
When you first open the ORK Framework editor, a new ORK Project asset will be created.
This asset will contain all your ORK Framework settings made in the editor.
It's located at 'Assets/ORK Framework/ORKProject.asset'.

- Event assets
When you create events (e.g. game events, battle events, etc.), each event is stored in a separate file.
You can save the event assets anywhere in your Unity project.
To keep things organized, it's recommended to create a folder structure mirroring the purpose of the events.
E.g. separating game events by location.



-------------------------------------------------------------------------------------------------------------------------------------------------------
Editor and Scene Wizard
-------------------------------------------------------------------------------------------------------------------------------------------------------

- ORK Framework editor
In ORK Framework you'll create your game's data in the ORK Framework editor.
You can open the editor using Unity's menu: Window > ORK Framework.
You can also open the editor using the hot-key 'CTRL + ALT + O'.

The editor is separated into different sections, each section contains multiple sub-sections.
When saving, the editor will display what will change and, depending on what's been changed, offers to update events, scenes and prefabs.
When scenes are updated, please make sure to save your current scene first.

- ORK Scene Wizard
The ORK Scene Wizard is used to add your data to your scenes to create gameplay.
You can open the scene wizard using Unity's menu: Window > Scene Wizard.
You can also open the scene wizard using the hot-key 'CTRL + ALT + W'.



-------------------------------------------------------------------------------------------------------------------------------------------------------
Tutorials
-------------------------------------------------------------------------------------------------------------------------------------------------------

You can find different types of tutorials here:
http://orkframework.com/tutorials/

It's recommended to start with the Game Tutorials to learn using ORK Framework.
This series of tutorials covers creating a game with ORK Framework from start to finish.
You can find them here:
http://orkframework.com/tutorials/game/

If you're seeking information/help with a specific feature, take a look at the how-tos:
http://orkframework.com/tutorials/howto/

If you have any tutorial requests, don't hesitate and contact me:
contact@orkframework.com



-------------------------------------------------------------------------------------------------------------------------------------------------------
Support
-------------------------------------------------------------------------------------------------------------------------------------------------------

Need help or found a bug?

Please search for a solution in the ORK Community forum:
http://forum.orkframework.com/

Didn't find anything? Contact me:
contact@orkframework.com



-------------------------------------------------------------------------------------------------------------------------------------------------------
Documentation
-------------------------------------------------------------------------------------------------------------------------------------------------------

The documentation is built into the ORK Framework editor.
All settings are explained in the help window in the ORK Framework editor.

Information and help texts will be displayed if you hover with the mouse over a setting or foldout.
You can change this behaviour in the editor settings (Editor > Editor Settings).

There currently is no separate documentation available.



-------------------------------------------------------------------------------------------------------------------------------------------------------
Demo
-------------------------------------------------------------------------------------------------------------------------------------------------------

The demo.unitypackage file contains a demo project.

- Setting up the demo
To get the demo running, import the contents of demo.unitypackage into an empty project.
Make sure that ORK Framework is NOT imported before importing the demo.

Now, add all Unity scenes found in 'Assets/Tutorial Resources/Scenes/' to the project's build settings.
Use the Unity menu to open the build settings (File > Build Settings...) and drag the scenes on the 'Scenes In Build' area.

- Starting the demo
To start the demo, open the main menu scene (0 Main Menu) and press play.

- Controls
Use the 'Arrow' keys to move your player and change menu selections.
The 'Escape' key opens the menu. Use 'Enter' to accept and 'Right-Ctrl' to cancel.
In real time combat, use 'Space' to attack and 'Left-Ctrl' to open the battle menu.



-------------------------------------------------------------------------------------------------------------------------------------------------------
Package Description
-------------------------------------------------------------------------------------------------------------------------------------------------------

- Gizmos (folder)
Contains the gizmo icons (32x32) used by ORK Framework.

- DLL (folder)
3 DLLs containing ORKFramework.

- demo.unitypackage
Contains a complete demo project.
Please see the 'Demo' section for details.

- gameplay_source_code.zip
Contains the gameplay related source code in a MonoDevelop project.
Please read the included README.txt for details.
There currently is no separate documentation available.



-------------------------------------------------------------------------------------------------------------------------------------------------------
iOS Hints
-------------------------------------------------------------------------------------------------------------------------------------------------------

If you're building your project on iOS, you may run into some problems:

- Crash after splash screen: "You are using Unity iPhone Basic. You are not allowed to remove the Unity splash screen from your game"
To fix this, change in XCode's build settings the 'Compress PNG files' setting to NO and build the project again.

- Crash after splash screen: "Ran out of trampolines of type 2"
This is caused by use of generics, you have to tell the AOT compiler allocate more trampolines.
To fix this, change in Unity's Player Settings > Other Settings the 'AOT Compiler Options' to nimt-trampolines=512.
If you're still receiving a trampoline error, increase the number, e.g. 1024.


You can find more detailed instructions on the Unity trouble shooting page:

http://docs.unity3d.com/Documentation/Manual/TroubleShooting.html



-------------------------------------------------------------------------------------------------------------------------------------------------------
ORK Version Changelog
-------------------------------------------------------------------------------------------------------------------------------------------------------

Version 2.1.3:
- new: Interactions: 'Trigger Stay' start types available. Starts an interaction (e.g. event, item collector) while the player (or another object) is within the object's trigger.
- new: Interactions: 'Collision Enter' start types available. Starts an interaction (e.g. event, item collector) when the player (or another object) starts colliding with the object. Requires both objects to have a collider and at least one object to have a rigidbody.
- new: Interactions: 'Collision Exit' start types available. Starts an interaction (e.g. event, item collector) when the player (or another object) stops colliding with the object. Requires both objects to have a collider and at least one object to have a rigidbody.
- new: Interactions: 'Collision Stay' start types available. Starts an interaction (e.g. event, item collector) while the player (or another object) is colliding with the object. Requires both objects to have a collider and at least one object to have a rigidbody.
- new: Battle Menus: 'Change Member' menu item type available. Allows changing a combatant against a member of the non-battle group.
- new: Combatants: Battle Animations: 'Retreat Animation' available. Uses battle events to animate a combatant's retreat from battle when using the 'Change Member' command. Needs a 'Calculate' step to exchange members.
- new: Combatants: Battle Animations: 'Enter Battle Animation' available. Uses battle events to animate a combatant joining the battle when using the 'Change Member' command.
- new: Control Maps: 'Change Member' action available. Exchanges the combatant with a defined non-battle member (defined by index).
- new: Status Effects: 'Change Member' end action type available. Exchanges the combatant with a defined non-battle member (defined by index) after the status effect ends.
- new: Battle AI: Action Steps: 'Change Member' step available. Exchanges the combatant with a defind non-battle member (defind by index).
- new: Battle AI: Status Steps: 'Get Status Value' step available. The combatant with the highest or lowest value of a selected status value will be added to the target list.
- new: Battle AI: Status Steps: 'Get Attack Attribute' step available. The combatant with the highest or lowest value of a selected attack attribute will be added to the target list.
- new: Battle AI: Status Steps: 'Get Defence Attribute' step available. The combatant with the highest or lowest value of a selected defence attribute will be added to the target list.
- new: Loot: 'Variable Condition' settings available in loot tables. If a loot table is available can depend on variable conditions (either global or object variables on the combatatant or spawner).
- new: Loot: 'Set After Drop' settings available in loot tables. Loot tables can change game variables (either global or object variables on the combatatant or spawner) after being used/dropped by a combatant.
- new: Combatant Spawners: 'Move AI' settings available. A combatant spawner can block or override the move AI of spawned combatants.
- new: Event System: Status Steps: 'Check Combatant' step available. Checks if an object (e.g. actor) is a selected combatant.
- new: Event System: Active Group Steps: The 'Check Player' step can now check objects (e.g. actors) if they are the player.
- new: Inspectors: The ORK Framework object (created when playing) now shows all global game variables in the inspector.
- new: Inspectors: The 'Object Variables' component now shows all game variables of the object in the inspector.
- new: Item Collectors: 'Show Notification' setting available for 'Single' and 'Random' item collectors. The item collection notification will be skipped when disabled.
- new: Shop Layouts: 'Sell Without Items' setting available. If disabled, 'Sell' button will be disabled when no items are available to be sold. By default disabled.
- new: Shop Layouts: 'Auto Close Sell' setting available. If enabled, the sell mode will automatically be closed when the last item has been sold. By default enabled.
- new: Inventory Settings: Drop Item Settings: 'Collector Star Type' setting available. Select the start type of the item collector used for dropped items. By default set to 'Interact'.
- new: HUDs: Combatant HUDs: 'Start Index Offset' setting available for 'Group' mode combatant HUDs. Starts displaying the combatant list from the defind offset, i.e. combatants before that index will be skipped.
- new: HUDs: Combatant HUDs: 'Limit List Length' settings available for 'Group' mode combatant HUDs. Limit the number of displayed combatants.
- new: Animations: Mecanim: 'Set Layer Weight' settings available for mecanim animations. Optionally sets the current weight of the animation's layer before playing it.
- new: Menu Screens: 'Close Screens (Opening)' settings available for menu screens not using 'Single Screen' mode. Automatically closes selected menu screens when opening the (non-single) menu screen.
- new: Menu Screens: 'Close Screens (Closing)' settings available for menu screens not using 'Single Screen' mode. Automatically closes selected menu screens when closing the (non-single) menu screen.
- change: Combatant Spawners: The spawner will now set its game variables each time a combatant spawned by the spawner is killed.
- fix: Menu Screens: The drag info will now be properly displayed in menu screens that pause the game.
- fix: Camera Events: Camera events wont throw errors and block control when changing scene while a camera event is active.
- fix: Event System: Movement Steps: The 'Transform to Variable' step is now correctly setting the Vector3 game variable.
- fix: Combatant Groups: The additional battle gains are now also collected when using loot tables.
- fix: Shops: 'Accept' input key doesn't throw errors when shop is open in sell mode without items to sell.
- fix: HUDs: Control HUDs: 'Control' type HUDs now correctly support inputs with hold time.


Version 2.1.2:
- new: Battle Settings: 'Auto Join' settings available. Combatants within range of a starting battle can automatically join the battle. This is only available in arena battles (i.e. using the 'Battle' component), not in real time area battles.
- new: Battles: Battle components can override the default 'Auto Join' settings from the 'Battle Settings'.
- new: Status Effects: 'Keep Overflow' setting available for status conditions. Changes exceeding the possible changes for status values will be remembered and added to the next change. E.g. 5.25 can only do a change of 5, 0.25 will be remembered and added to the next change.
- new: Status Values: 'Ignore 0 Damage' setting available for damage and critical damage notifications. Optionally ignores a damage of 0 (i.e. no damage) and doesn't perform the notification text and HUD flash.
- new: Abilities, Items: Status Changes: 'Ignore Barrier' setting available in user/target changes. Optionally ignores barrier values of 'Consumable' type status values and targets the status value directly.
- new: Status Effects: Status Conditions: 'Ignore Barrier' setting available. Optionally ignores barrier values of 'Consumable' type status values and targets the status value directly.
- new: Combatants: Status Value Time Changes: 'Ignore Barrier' setting available. Optionally ignores barrier values of 'Consumable' type status values and targets the status value directly.
- new: Battle Settings: Player/Enemy Advantage: 'Ignore Barrier' setting available. Optionally ignores barrier values of 'Consumable' type status values and targets the status value directly.
- new: Battle System: Bonus Settings: 'Ignore Barrier' setting available. Optionally ignores barrier values of 'Consumable' type status values and targets the status value directly.
- new: Event System: Status Steps: 'Ignore Barrier' setting available in the 'Change Status Value' step. Optionally ignores barrier values of 'Consumable' type status values and targets the status value directly.
- new: Event System: Movement Steps: 'Change Gravity' step available. Change Physics.gravity or Physics2D.gravity - influences all game objects with a 'Rigidbody' or 'Rigidbody2D' component.
- new: Battle Menus: 'Audio Settings' available. A battle menu can now play an audio clip when being opened and closed.
- new: Abilities, Items: 'Target Requirements' settings available. A target can optionally depend on status requirements and variable conditions. If the requirements aren't met, the combatant can't be targeted.
- change: Battles: Battles can't start while changing scenes.
- change: Save Games: Status effects of player combatants are now saved.
- change: Dialogues, Menus: Accepting a choice will now also reset all ORK input keys instead of only the Unity input axes. This fixes problems when using the accept key also to call the menus.
- fix: Menu Screens: Displaying the back or unequip button first can cause errors when not displaying unequippable equipment.
- fix: Combatants: Level up now allows to gain more than one level at once.
- fix: Battle Settings: The enemy counter type 'Letter' now correctly displays letters exceeding A-Z as AA-AZ, BA-BZ, etc.
- fix: Event System: Image Steps: Removing lower ID images before higher ID images resulted in errors.
- fix: HUDs: Using icons for status value bars without empty icons displayed the already consumed icons at the position of the last icon.
- fix: Battles, Combatants: Enabling 'Keep Prefab' in the combatant's settings could prevent a battle from ending when all enemies have been killed.
- fix: Real Time Battle Areas: Implemented a workaround for a Unity bug where the player quickly leaves and enters the area's trigger, although he is still inside it.


Version 2.1.1:
- new: Unity 4.5: ORK Framework now supports/requires Unity 4.5.
- new: Game Controls: Collision Camera: 'Collision Camera' settings available in the game control settings. The new 'Collision Camera' component uses racasts to find objects between player and camera and places the camera accordingly. Can be used with all built-in and custom camera controls, and is also active during events (i.e. while camera changes).
- new: Float Values: Advanced float settings throughout the framework (e.g. changing game variables) now allow using the current time of day (i.e. time since midnight in seconds) and date and time (i.e. time since 1-1-1970 in seconds). You can use this to use the real time or check for days since something was done.
- new: Status Values: 'Barrier' settings available for 'Consumable' type status values. You can use other 'Consumable' type status values as barriers, i.e. they will consume damage instead (as long as they haven't reached their minimum value). They can either fully consume a damage, or only a defined percent range (0-100 %).
- new: Status Values: 'Death On' setting replaces 'Death on Minimum' for 'Consumable' type status values. You can now select 'None' (i.e. doesn't kill the combatant), 'On Minimum' (combatant dies when value reaches its minimum) and 'On Maximum' (combatant dies when value reaches its maximum).
- new: Items: 'Equipment Part Changes' settings available. Items can add/remove equipment parts to/from a combatant. This can be used to either add additional equipment parts or to block/remove equipment parts from the combatant/class settings.
- new: Weapons, Armors: 'Equipment Part Changes' settings available. Weapons and armors can add additional equipment parts and block other equipment parts while being equipped. This can be done per equipment level.
- new: Abilities: 'Equipment Part Changes' settings available in passive abilities (i.e. useable in 'None'). Passive abilities can add additional equipment parts and block other equipment parts. This can be done per ability level.
- new: Status Effects: 'Equipment Part Changes' settings available. Status effects can add additional equipment parts and block other equipment parts.
- new: Classes, Combatants: The weapon/armor settings are now split into available and unavailable equipments (due to equipment parts). Unavailable equipment was previously not displayed and couldn't be enabled. Also, automatic unselection of weapons/armors due to equipment part changes is now disabled.
- new: Camera Positions: 'Rotation Is Offset' setting available. Uses the defined rotation of the camera as an offset to the target's rotation.
- new: Quests: Quests can now learn log texts to the player when being added to the player's quest list, the quest finishes or fails.
- new: Quest Tasks: Quest tasks can now learn log texts to the player when being activated or the task is finished or failed.
- new: Quests, Quest Tasks: Experience rewards can now optionally be given to the whole group (or only battle group) and split between group members.
- new: Event System: Spawn Steps: 'Destroy Object' step available. Destroys a game object.
- new: Event System: Equipment Steps: 'Check Part Available' step available. Checks if an equipment part is available (i.e. can be equipped, ignoring locked parts).
- new: Event System: Equipment Steps: 'Change Equipment Part' step available. Adds/removes equipment parts to/from a combatant. Removing only allows removing previously added parts. Can be used to add additional equipment parts to combatants.
- new: Event System: Equipment Steps: 'Change Blocked Part' step available. Adds/removes a blocked equipment part to/from a combatant. A blocked equipment part isn't available for equipping. Can be used to remove equipment parts from combatant/class settings.
- new: Event System: Crafting Steps: 'Learn Recipe' and 'Forget Recipe' steps can now optionally learn/forget all crafting recipes of a selected crafting type.
- new: Event System: Check Steps: 'Chance Fork' step available. Define multiple value ranges, the next step of the first range that contains the random chance (minimum <= chance <= maximum) will be executed.
- new: Event System: Camera Steps: 'Collision Camera' step available. Enable/disable the collision camera - requires a 'Collision Camera' component attached to the camera.
- new: Event System: Movement Steps: 'Stop Movement' step available. Stops movement from 'Change Position', 'Move Into Direction' and 'Curve Move' steps.
- new: Game Events: 'Starting Object' actor type available. Uses the game object that started the event as actor. In most cases this will be the player, but you can use this to access other objects that started an event.
- new: Battle AI: Check Steps: 'Chance Fork' step available. Define multiple value ranges, the next step of the first range that contains the random chance (minimum <= chance <= maximum) will be executed.
- new: Battle AI: Check Steps: 'Check Game Variable' step available. Checks for game variable conditions - if the conditions are valid, the 'Success' step will be extecuted, otherwise 'Failed'.
- new: Battle AI: Check Steps: 'Game Variable Fork' step available. Checks a single game variable for multiple conditions and executes the first valid condition's next step.
- new: Formulas: Check Steps: 'Check Chance' step available. Which step will be executed next is decided by chance.
- new: Formulas: Check Steps: 'Chance Fork' step available. Define multiple value ranges, the next step of the first range that contains the random chance (minimum <= chance <= maximum) will be executed.
- new: Menu Screens: 'Alive User' setting available. When opening the menu screen and the current user is dead, the first alive member of the group will be used as user. Since dead combatants can't use items, this can be used to automatically switch to a different user when using items in the inventory menu.
- change: Items, Abilities: Status value and status effect change settings can now be copied and moved.
- change: Editor: The drag bar positions are now saved each time when the editor is closed. Previously, they have only been saved when the data has been saved. The remembered sections will be reset the first time you open the editor after this update.
- change: Game Events: The blocking event state will be removed during battles started by the the 'Start Battle' step. The battle controls are now fully useable during those battles.
- change: Scene Changers: When using a scene changer during battles, the battle will end.
- fix: Input Keys: Releasing an input key using 'Hold Time' will now correctly reset the hold timer.
- fix: Combatants, Status Effects: Auto effects will now be checked after initializing the start values of consumable status values.
- fix: Menu Screens: Hiding not equipable equipment (i.e. disabling 'All Weapons/Armors') caused a equipping wrong equipment.
- fix: Combatants: Conditional prefabs now correctly check for the combatant's death.
- fix: Battle System: Active Time Battles: The 'Start Calculation' formula is now correctly used at the start of the battle.
- fix: Battle System: The death event of the last player combatant didn't play when not using 'End Immediately'.
- fix: Game Over: Dead combatants played the idle animation while fading to the game over scene.
- fix: Item Collectors: Not using quantity limits could lead to items not being collected.


Version 2.1.0:
- new: Quest System: The new quest system consists of 'Quest Types', 'Quests' and 'Quest Tasks'. They are created in the 'Game' section of the ORK Framework editor.
- new: Quest Types: Quest types are used to separate quests into different types. The quest types can be used in menus and HUDs to filter/limit displaying quests.
- new: Quests: Quests can give rewards (experience, items, equipment and money) upon successful completion. A quest consists of multiple quest tasks.
- new: Quest Tasks: Quest tasks are the actual things a player needs to do in a quest. You can define requirements for activating, finishing or failing a task. The task's progress can be handled automatically.
- new: Menu Screens: 'Quest' menu part available. Displays the quests of the player and can be separated by quest types. Quests can optionally be set active/inactive.
- new: Interactions: Quest/task status conditions available in all interactions (e.g. Event Interaction, Item Collector).
- new: Requirements: 'Knows Logs', 'Has Quests', 'Has Not Ended Quests' and 'Has Ended Quests' settings available. Requires the player to knows at least one log, quest, active/inactive quest or finished/failed quest.
- new: Game Variables: Advanced Vector3 operations available. Setting a Vector3 game variable can now use the following operators: Add, Sub, Set, Cross, Min, Max, Scale, Project and Reflect. This is available throughout the entire framework.
- new: Inventory, Currencies, Items, Weapons, Armors: 'Inventory Notifications' settings available. Adding/removing items, weapons, armors and currency to/from the player's inventory can optionally display notifications. Also, if something can't be added due to inventory limitations can display a notification. Currencies, items, weapons and armors can override the default notifications.
- new: Inventory, Crafting Recipes: 'Crafting Notifications' settings available. Learning/forgetting a crafting recipe and using it (successfully/failed) can optionally display notifications. Crafting recipes can override the default notifications.
- new: Combatants: Auto Attacks: 'Target Type' setting available. Select the possible targets of auto attacks, e.g. only group/individual targets or all combatants.
- new: Combatants: 'Keep Prefab' settings available in the 'Death Settings'. The combatant's prefab wont be destroyed when the combatant dies (only for non-members of the player group).
- new: Text Codes: New text codes available for quest, quest task and quest type information.
- new: Event System: 'Quest Steps' available. There are various new steps available to manage/check the status of a quest and quest tasks.
- new: Event System: Dialogue Steps: 'Quest Choice' step available. Displays a dialogue or choice dialogue with quest information of a selected quest.
- new: Event System: Dialogue Steps: The message of 'Show Dialogue', 'Teleport Choice' and 'Value Input Dialogue' steps can optionally also be printed to the console.
- new: Event System: Dialogue Steps: The cancel choice in 'Teleport Choice' steps can optionally be the first choice in the list.
- new: Event System: Status Steps: 'Initialize to Level' step available. Initialize a combatant/group to a defind level and class level. All previous progress (e.g. learned abilities, status values) will be lost, all equipment will be unequipped.
- new: Event System: Base Steps: 'Wait For Input Fork' step available. Waits for an input key (out of multiple keys) to be pressed, either for a set amount of time, or until the key has been pressed. The next step of the input key that's pressed first will be executed.
- new: Event System: Statistic Steps: 'Clear Statistic' can now optionally reset a selected statistic value instead of all values.
- new: Event System: Statistic Steps: 'Check Statistic' step available. Checks a selected statistic value against a defined value.
- new: Event System: Statistic Steps: 'Statistic To Variable' step available. Stores a selected statistic value into a float game variable.
- new: Event System: Movement Steps: 'Transform To Variable' step available. Stores a transform's position, rotation or scale into a Vector3 game variable.
- new: Event System: Movement Steps: 'Block Move AI' step can now optionally block the move AI of a selected object instead of blocking it completely (i.e. for all objects).
- new: Battle Events: Battle Steps: 'End Phase' step available. The phase will end after the action finishes - combatants who didn't chose an action yet will not be able to do so. Only used in 'Phase' battles.
- new: Status Values: 'Start Value' settings available for 'Consumable' type status values. Define the start value of 'Consumable' status values either in percent of their maximum status value or an absolute value. By default 100 % of their maximum status value.
- new: Status Values: 'No Regeneration' setting available for 'Consumable' type status values. Optionally excludes a status value from being fully recovered upon regeneration (e.g. on level up or by the 'Regenerate' event step).
- new: Menu Settings, GUI Boxes: 'Show Unfocused' setting available for choice icons. The choice selection icon can optionally be displayed on a not focused GUI box.
- new: Battle AI: 'End Phase' setting available in all action steps. The phase will end after the action finishes - combatants who didn't chose an action yet will not be able to do so. Only used in 'Phase' battles.
- new: Game Settings: Area Notifications: 'Queue Area Notifications' setting available. Area notifications can optionally be displayed in sequence instead of replacing the current notification with a new one.
- new: Areas, Game Settings: Area Notification: 'Play Sound' settings available. An area notification can play an audio clip (even when not displaying the notification box).
- new: Areas, Game Settings: Area Notification: 'Show Portrait' setting available. Showing an area's portrait in the area notification is now optional. By default enabled.
- new: Battle Texts: 'Queue Infos' setting available. Battle infos can optionally be displayed in sequence instead of replacing the current info with a new one.
- new: HUDs: 'Quest' type HUD available. Displays a list of quests and their tasks. The displayed quests can be filtered by quest type and status.
- new: HUDs: 'Hide Empty HUD' setting available. A HUD will be hidden if it doesn't display any elements. Not available for 'Control', 'Navigation' and 'Console' type HUDs.
- new: HUDs: 'Quest' and 'Quest Task' settings available in 'Tooltip' type HUDs. A tooltip can be dispalyed when hovering the mouse above a quest or quest task in a 'Quest' type HUD.
- new: Main Menu: 'Stop Music' setting available. The current music is stopped when starting a new game. By default enabled.
- new: Status Effects, Battle Texts: 'Remove Status Effect' notification text settings available. You can display a notification text when a status effect is removed from a combatant.
- change: Object Variables: Accessing an object variable's component in the start function of a script now also initializes the variables.
- change: Event System: Moving, rotating and scaling objects over time will now start immediately. Previously, the changes started in the next frame, leading to sometimes not being finished completely after the wait time.
- change: Event System: PlayerPref Steps: The PlayerPrefs are saved each time after setting a PlayerPrefs.
- change: Inventory: Inventory limits prevent getting items from item collectors/boxes and buying items.
- fix: GUI Boxes: 'Select First' is now working correctly.
- fix: Menu Screens: The description part in equipment screens now displays the correct part information.
- fix: Menu Screens: Crafting menus could throw an error when using a choice for creating recipe outcomes.
- fix: Menu Screens: Group menus could throw an error (and block the menu from exiting) when using complex combatant layouts.
- fix: Event System: Base Steps: The 'Wait For Input' step now receives the input from input keys with 'Hold Time' correctly.
- fix: Event System: Game objects that are destroyed before being used in steps wont throw errors.
- fix: Console: Learning and forgetting console texts used the action range settings instead of learn/forget range.
- fix: Weapons, Armors: Enabling/disabling equipment parts wont throw errors when not using combatant equipment override.
- fix: Shops: Selling the last item of the inventory (without displaying 'Back' buttons) wont get you stuck in the shop any longer.
- fix: Save Games: Saving scene data (e.g. finished battles, collected items) is now working correctly.
- fix: Status Effects, Abilities, Items: Status effects overriding an ability/item attack attribute could result in an error.


Version 2.0.9a:
- new: Battle Events: Battle Steps: 'Use Ability Calculation' step available. Uses an ability (without animation) - the user/target changes will be calculated. The user doesn't need to know the ability.
- new: Battle Events: Battle Steps: 'Use Item Calculation' step available: Uses an item (without animation) - the user/target changes will be calculated.
- new: Shop Layouts: 'Show Portrait' setting available in the 'List Box' settings. The portrait of a selected item, weapon or armor in can be displayed.
- change: Controls: Blocking events will now prevent the use of battle related controls (e.g. control maps, group/individual target keys, ...).
- change: Editor: Combatants: The combatant's settings have been rearranged into 'Base Settings', 'Status Settings', 'Attacks & Abilities', 'Inventory & Equipment', 'Battle Settings' and 'Animations & Movement'.
- fix: Custom Controls: Custom camera controls aren't blocked by player control anymore.
- fix: Menu Screens: The description part now displays the correct content information of an equipped weapon/armor when selecting an equipment part.
- fix: Phase Battles: The next phase now starts automatically if no combatant of the current phase can perform an action.


Version 2.0.9:
- new: Event System: 'Found Objects' are available in all actor/waypoint/prefab-selections. Found objects are game objects in the scene that have been searched (and found) by the new 'Search Object' step.
- new: Event System: Base Steps: 'Search Objects' step available. Searches for game objects in the scene and adds or removes them to the 'Found Objects' list, or removes all found objects from the list.
- new: Battle Events: New actors available. Use 'User Group', 'Target Groups', 'All Allies', 'All Enemies' and 'All Combatants' actors for advanced battle events.
- new: Battle Events: Battle Steps: 'Change Action Targets' step available. A combatant is added or removed as a target of the action, or all targets can be removed.
- new: Game Events: Actors and waypoints have advanced 'Find Object' settings. You can now search for objects within a defined range.
- new: Combatants: 'Equipment Settings' available. Combatants can optionally override the equipment settings of their class, making the available equipment parts, weapons and armors independent from the class.
- new: Combatants: 'Experience Rewards' now have advanced reward value settings. You can use a value, game variables, formulas and other sources for the experience reward value.
- new: Abilities, Items: 'Animation Settings' available in the 'Damage Dealer Settings'. Damage dealers can optionally use battle events to create more complex actions when hitting a damage zone.
- new: Damage Zones: 'Audio Settings' available. Damage zones can play audio clips or a sound type when receiving damage from a damage dealer.
- new: Equipment Viewers: Advanced material settings available. You can optionally use the renderer of a child object and use an indexed material (if the renderer uses multiple materials).
- new: Menu Settings: 'Mouse Over Selection' setting available. Optionally selects (not accepts) a choice when the mouse cursor is above it (only on the currently focused GUI box).
- new: Game Controls: Custom Controls: The custom control behaviours are now separated from player/camera controls. You can select on which object (player or camera) a control is located and with which control they'll be blocked (player or camera).
- new: Placement: 'Scale' settings available for placing/mounting objects (e.g. spawn prefab step, cursor placement, etc.) throughout the entire framework.
- new: Quantity Selections: 'Hide Buttons' setting available for quantity selection buttons. Optionally hide the buttons, but still allows changing the quantity with the input keys.
- new: Quantity Selections: Advanced text codes available to display inventory money/item changes, details about the currency and the icon of the item.
- new: Combatant Component Inspector: The combatant component's inspector now displays advanced information on a combatant's battle data and actions.
- new: Menu Screens, Item Boxes: Description Part: Advanced text codes available and optional custom description text.
- change: Value Input: The value input field name is now multi-lingual.
- fix: Combatants: The start equipment's requirements will now also use bonuses from classes.
- fix: Shop Layouts: Buy/sell quantity selections got mixed up when using something other than 'Default'.
- fix: Battle Menus: The target cursor wasn't removed when clicking on a target to select it.
- fix: Phase Battles: Selecting 'End Phase' after canceling a combatant's battle menu didn't progress to the next phase.
- fix: Phase Battles: The combatant selection with 'Only Available' enabled and combatants not able to perform an action didn't progress to the next phase.
- fix: Active Time Battles: Doing nothing (i.e. 'End' battle menu item) resultet in the battle menu not reappearing when the timbar filled again.
- fix: GUI Boxes: Disabling the 'Use Cancel Button' setting was ignored.


Version 2.0.8:
- new: Formulas: 'Initial Value' settings available for formula selections throughout the entire framework. The formula will use the initial value as it's base and start the calculation with that value. The start value of the formula will be calculated to the initial value based on the selected operator in the formula's settings.
- new: Abilities, Items, Currencies, Weapons, Armors, Crafting Recipes: 'Portrait Settings' available. The portrait can be displayed by menus when the ability, item, currency, weapon, armor or crafting recipe has been selected.
- new: Menu Screens: 'Show Portrait' setting available in 'Ability', 'Ability Tree', 'Crafting', 'Equipment' and 'Inventory' menu parts. The portrait of a selected item, currency, weapon or armor in the inventory screen can be displayed.
- new: GUI Boxes: 'Show Button' setting available. Displaying a button around the content of a choice, tab or ok/cancel button is now optional (by default enabled).
- new: Abilities: Advanced 'Cast Time' settings available. The cast time of an ability can now also use formulas, game variables and other sources.
- new: Abilities: Advanced 'Reuse After' settings available. The reuse turns/time of an ability can now also use formulas, game variables and other sources.
- new: Shop Layouts: The 'List Box' settings can now optionally use a different layout for the back button. Use it when using custom info in the content layout that would otherwise also be displayed on the back button.
- new: Game Controls: Advanced 'Member Change Keys' settings available. Switching the player is optional for the field, turn based, active time, real time and phase battles. Switching the current menu user is available for active time and real time battles only.
- new: Interactions: 'In Blocked Control' setting available for 'Trigger Enter', 'Trigger Exit', 'Key Press' and 'Drop' interactions. The interaction can be started even while the player control is blocked (e.g. during a control blocking battle or event).
- new: Main Menu: The main menu can display a portrait. Optionally, every main menu option can display a different portrait.
- new: Battle Menus: Battle menus can display portraits of selected items, abilities, equipment, targets and command targets.
- new: Battle Menus: 'Use Sub-Menu Boxes' setting available. Battle menus can optionally use different GUI Boxes for different sub menus (e.g. ability type menu, item menu, target menu).
- new: Battle Events: Battle Steps: 'Activate Damage Dealer' step can now use the ability's or item's audio clip and prefab defined in their damage dealer settings.
- new: Damage Dealers: Environmental damage dealers now use the audio/prefab settings defined in the ability's damage dealer settings.
- fix: Shop Layouts: The content layout of the 'List Box' settings now displays custom info.
- fix: Event System: Movement Steps: 'Change Position' step using movement by speed now only faces the move direction if 'Face Direction' is enabled.
- fix: Real Time Battle Areas: Battle now ends correctly when leaving real time battle areas.
- fix: Input Keys: Getting the axis value from input keys set via HUD or code is now correct.
- fix: Menu Screens: Spamming the 'Cancel' key when having multiple non-single menu screens opened caused problems.
- fix: Turn Based Battles: Killing an enemy that had the last action could lead to the battle not continuing.
- fix: Real Time Battles: Death of combatants could lead to wait times between actions.


Version 2.0.7:
- new: GUI Boxes: You can use different text format settings for the text, info and title of choices.
- new: Control Maps: 'Need Targets' setting available. 
- new: Camera Controls: 'Mouse' camera control zoom by keys received an option to use a single key as axis instead of two separate buttons. Use this option for mouse wheels.
- new: Finding Objects: Finding objects in game event actors, navigation markers and custom main menu choices can now search for attached components. The found object is the one the component is attached to.
- new: Weapons, Armors: 'Viewer Material' setting available. Weapons and armors can change the material used by a renderer attached to the same game object as an 'Equipment Viewer'.
- new: Group Targets: You can now select different group targets for different abilities, ability types, items and item types. Settings are made in 'Battle System > Battle Settings'.
- new: Individual Targets: Set individual targets for a combatant to use abilities and items on. Work like group targets. Settings are made in 'Battle System > Battle Settings'.
- new: Combatants: 'Attack Individual Target' setting available. Uses an individual target for AI attacks.
- new: Combatants: 'Run Speed Threshold' and 'Sprint Speed Threshold' settings available in the combatant's 'Animation Settings'. Use thresholds for a smoother transition between walk/run and run/sprint animations.
- new: Battle Menus: 'Auto Target Settings' available. Optionally use abilities (also attacks) and items automatically on a group target or individual target.
- new: HUDs: 'Combatant Origin' setting available in 'Combatant' type HUD elements (except for 'Shortcut' elements). Select if the displayed information comes from the HUD's user, a group/individual target or the last target (of an attack, ability or item) of the user.
- new: HUDs: Shortcuts ('Combatant' type HUDs') can optionally target a group/individual target automatically when double clicked.
- new: Damage Types: The new damage types define the animation types used for damage, critical damage and evasion. Damage types are assigned to ability/item types and can optionally be assigned to abilities and items as well. This allows having different damage/evasion animations for each ability or item.
- new: Ability Types, Item Types: Set the default damage type for all abilities/items of the ability/item type.
- new: Abilities, Items: Abilities and items can override the default damage type of their ability/item type.
- new: Move AI: Advanced status requirements available for hunting and flee conditions.
- new: Interactions: The 'Trigger Enter' and 'Trigger Exit' start types of interactions can now be started by other game objects than the player. If an object can start the event can be checked by name/tag or by checking of added components, or both.
- new: Crafting Recipes: 'Audio Settings' available. Crafting recipes can play an audio clip when the creation has been successful or failed.
- new: Custom Controls: 'From Root' setting available. Searching/adding behaviour components will use the root of the game object - use this setting if the object isn't the real root.
- new: Custom Controls: You can optionally change fields and properties of custom control behaviours.
- new: Value Checks: 'Not Equal' check available. You can now use the not equal check in all value checks (previously only is equal, less or greater) - e.g. used in status requirements, distance checks, etc.
- new: Animations: 'Auto Move Speed Parameter' settings available for Mecanim. Optionally set the horizontal and vertical move speed of a combatant to float parameters of the game object's Mecanim animator.
- new: Scene Wizard: You can now create interaction controllers for 2D and 3D interactions.
- change: Status Values: 'Consumable' type status values can now only select 'Normal' type status values as maximum status value.
- change: Event System: 'Show Notification' step is now available in battle events, battle start events, battle end events and phase battle events.
- change: Battle Events: The 'Death' event now uses the combatants who attacked the dying combatant as targets.
- change: Animation Types: The animation types for damage, critical damage and evasion are now defined in 'Base/Control > Damage Types'.
- change: Difficulties: A combatant's 'Experience Rewards' are now influenced by the difficulty's faction status multipliers.
- change: Status Values: The percent bonus to combined 'Normal' type status values is now added after the final value calculation.
- change: Status Effects: When using formulas for status conditions, the calculation now happens every time, not only once.
- change: Status Effects: The caster of a status effect will now be used as the user for calculations of all changes, not only on cast.
- fix: Main Menu: The difficulty menu couldn't be displayed due to a bug.
- fix: Input Keys: Input keys of type 'Unity Input Manager' used as axis didn't receive input when the time scale was set to 0 (e.g. when using 'Freeze Game' in menu screens).
- fix: Menu Screens: The combatant's status values didn't update when the menu screen used 'Freeze Game'.
- fix: Menu Screens: Sub menus of menu screens that paused the game wheren't displayed and the game locked.
- fix: Abilities, Items: Using raycasts for 'None' target abilities/items is working now.
- fix: Event Interactions: When playing in the editor with an event interaction selected in the inspector, the event could be reloaded, stopping a running event from continuing.
- fix: Battle Start Events: The 'Spawn Combatants' step will now add player controls when spawning the player (e.g. when the battle takes place in a different scene).
- fix: Move AI: Stopping due to external influences (e.g. 'Stop Movement' status effect) wont cause loss of the hunted target any longer.
- fix: Combatant Spawners: Using combatant spawners with teleport battles (i.e. fighting in a different scene) wont result in the already spawned combatants missing in the battle.
- fix: Save Games: Error when loading inventory with money solved. Status values will now display the correct value. Equipment is now loaded correctly.
- fix: Compatibility: The 'EaseType' enumeration is now in the ORKFramework namespace and can be used with HOTween.
- fix: Status Effects: Having wrong auto apply/remove settings could lead to a stack overflow because a status effect was added and removed at the same time.
- fix: GUI Editor: Displaying 'Combatant' or 'Turn Order' type HUDs in the GUI Editor could crash Unity when having deadlocked auto apply/remove status effects.
- fix: Shops: Clicking on the 'Exit' button without selecting it first didn't return the control back to the player.


Version 2.0.6:
- new: Input Keys: 'Key Combo' input type available. Use a sequence of other input keys as input (e.g. 'A+A+B') as input. Define the used input keys and time the player has to press the next button. Each combo key can ignore selected other input keys (i.e. they wont cancel a combo).
- new: Value Inputs: Value inputs can now be selected and changed using input keys (i.e. vertical keys for selection, horizontal keys for slider changes, toggle bools and start text editing with accept).
- new: Event System: Equipment Steps: The 'Check Equipment' step can now check if an equipment part is generally equipped with a weapon or armor without specifying a specific equipment.
- new: Images: Use alpha mask textures to hide parts of displayed images. Used in image event steps, background images, portraits and HUDs.
- new: Event System: Rigidbody Steps: 'Add Force Rigidbody' step available. Add a force to 2D and 3D rigidbodies - optionally relative force (3D only).
- new: Event System: Rigidbody Steps: 'Add Torque Rigidbody' step available. Add torque to 2D or 3D rigidbodies.
- new: Event System: Rigidbody Steps: 'Position Force Rigidbody' step available. Add a force to a position, applying force/torque to 2D and 3D rigidbodies.
- new: Event System: Rigidbody Steps: 'Explosion Rigidbody' step available. Adds an explosion effect force to 3D rigidbodies.
- new: Event System: Rigidbody Steps: 'Stop Rigidbody' step available. Stops adding force/torque from other event steps to rigidbodies.
- new: Menu Screens: 'Remember Selection' setting available. Remembers the selected menu item when returning to the menu screen.
- new: GUI Boxes: 'Scale Settings' available in the 'Move In' and 'Move Out' settings. You can use this to create zoom effects when moving a GUI box in or out.
- new: Combatants: 'Experience Reward' settings available. You can now define experience rewards the player receives for defeating a combatant, without using the status development settings of the combatant. The real status values of the combatant and the exp reward can now be separated.
- new: Game Options: 'Random Battle Chance' option available in option menus (main menu and menu screens). Changes the chance for random battles happening. Used as percent of the chance defind in 'Random Battle Areas' (plus bonuses). E.g. 100 % is the default chance, 0 % is no random battles, 200 % is double chance.
- new: Abilities, Items: 'Random Battle Factor' settings available. Abilities and items can change the random battle factor for a defined amount of time. While the factor is changed by an ability/item, the factor bonuses of player group members are ignored. The factor is defined in percent.
- new: Control Maps: You can optionally select the equipment part used for an attack. The attack will only be used if a weapon with 'Override Attack' is equipped on the selected equipment part. Uses the attack of the equipped weapon.
- new: Battle Menus: 'Equipment' menu item type available. Lists the combatant's equipment parts and allows changing the equipment (similar to the equipment menu).
- new: Battle menus: 'Command' menu item type available. Give commands to other members of the group. Optionally only for 'AI Controlled' combatants. The given command will be performed the next time they're able to choose an action, giving a different command will override the previous one.
- new: Status Effects: 'Block Equipment Change' and 'Block Command' settings available. Status effects can now prevent a combatant from changing equipment and giving commands to other combatants.
- change: Battle Menus: Abilities and items can only be selected if targets are available.
- change: Control Maps: Abilities and items can only be used (and display a target menu) if targets are available.
- fix: Scene Wizard: Creating camera positions with the scene wizard will again add them to the data when the ORK Framework editor isn't already opened.
- fix: Combatants, Classes: Class development now uses the correct maximum values for class experience. The class experience is based on the status development of the class.
- fix: Battle System: Using items/abilities on combatants without doing damage will now also mark them as attacked by the user and allows the player to get battle gains from them.
- fix: Battle System: An enemy can't start a battle (when the player enters the combatant's battle start range) while a blocking menu is opened.
- fix: Battle Settings: Not using the target menu will now prevent the target menu from being displayed.


Version 2.0.5:
- new: Game Controls: Camera Control: 'Top Down Border' camera control available. Top down camera following the player until he crosses a border. The border is defind in the scene using a 'Camera Border' component with a 'Box Collider' (the collider defines the border).
- new: Scene Wizard: 'Camera Border' can be added to the scene through 'Create Object'. Adds a new game object with a 'Box Collider' and a 'Camera Border' attached.
- new: Event System: Camera Steps' 'Camera Control Target' step available. Changes the target of the camera control (i.e. the object the camera will follow). Requires the control to be a descendant of 'BaseCameraControl' (e.g. all built-in camera controls).
- new: Status Effects: 'End On Death' setting available. The effect will end when the combatant dies. By default enabled.
- new: Status Effects: 'Absorb Damage' settings available in 'Status Conditions'. Optionally absorbs damage dealt to a selected status value by abilities/items (with 'Use Absorb Effect' enabled).
- new: Status Effect Changes: 'Force' setting available. The status effect change will be forced, ignoring the target's status effect immunities.
- new: Abilities, Items: 'Use Effect Absorb' setting available. The user of the ability/item will absorb damage dealt according to applied absorb status effects.
- new: Abilities, Items: 'Volume' settings available for playing audio clips on status changes.
- new: Game Settings: 'Initial Game Variables' settings available. Define game variables that will be automatically set up when starting a game (i.e. before the main menu).
- new: Main Menu: 'Options' settings available. Add an options button to the main menu to display an options menu. You can change the music and sound volume, text speed and custom options (using global game variables).
- new: Menu Screens: 'Volume' settings available for the open and close audio clips.
- new: Menu Screens: 'Pause Settings' available. The game can optionally be paused while a menu screen is open. Pausing the game can also optionally pause the game time and freeze the game completely.
- new: Menu Screens: 'Options' menu part available. You can change the music and sound volume, text speed and custom options (using global game variables).
- new: Menu Audio: 'Value Input' audio settings available. A sound can be played when changing an input value (e.g. options menu, value input dialogues). Setting can be found in 'Menu Settings' and in GUI boxes which override the default audio settings.
- new: Inventory Settings: Item Collection: A sound can be played when collecting an item. The used sound can be either a selected sound type assigned to the player's combatant, or a selected audio clip.
- new: Inventory Settings: Item Box: Like the item collection, item boxes can now also play an animation and sound when the player interacts with them.
- change: Event System: Dialogue Steps: Choices in 'Show Dialogue' steps can be copied and moved.
- change: Event System: Inventory Steps: 'Add To Inventory', 'Remove From Inventory', 'Has In Inventory' and 'Drop Items' steps can now use formulas, game variables and other values to set the quantity and chance of items.
- change: Game Variables: The 'Is Valid' setting when checking game variables is now by default enabled.
- change: Stealing: Stealing items/money will now remove the stolen item/money the target's inventory, even if it's not the player.
- fix: Shops: Clicking on a 'Cancel' button when not using the buy/sell box and type box caused an error.
- fix: Node Editor: Event System: 'Show Dialogue' could throw an error when loading an event with a 'Choice' type dialogue without any choices.
- fix: Status Effects: Spawning prefabs for auto applied effects could sometime be displayed when spawning a combatant and immediately removing the effect.
- fix: Battle System: Enemies killed by other NPCs (not part of the player faction) wont give the player experience and loot - only if the player also attached the combatant.


Version 2.0.4:
- new: Shops: Selling individual items, weapons and armors can now depend on variable conditions.
- new: Shops: 'Sell to Shop' settings available. You can optionally limit which item types the player can sell to a shop.
- new: Text Code: 'Log Text' text code available. Displays the text of a log text, e.g. #logtext5# displays the text of log text with ID (index) 5.
- new: Game Controls: Custom player/camera control scripts can now be added to child objects.
- new: Console Settings: 'Unity Console Output' setting available. Optionally print new console lines in the Unity console when playing in the Editor.
- new: Event System: Equipment Steps: 'Lock Equipment Part' step available. Lock/unlock an equipment part of a combatant. Locked equipment parts can't change equipment.
- new: Event System: Equipment Steps: 'Check Part Locked' step available. Checks if a selected equipment part of a combatant is locked.
- new: Event System: Variable/Inventory Steps: 'Inventory To Variable' step available. Stores the quantity of a selected item, currency, weapon or armor found in an inventory into a float game variable.
- new: Status Effects: End after turn/time now also allows using formulas, game variables, PlayerPrefs and game time to determine the turns/time.
- new: Mouse/Touch Controls: New mode 'Hold' available for mouse/touch controls. Recognizes the input while holding it down (i.e. everything between 'Start' and 'End'). E.g. used in the 'Mouse' player controls.
- new: GUI Boxes: 'Selected Choice Offset' setting available. Optionally add an offset to the x-position of a selected choice. Setting also editable in the WYSIWYG editor.
- new: Node Editor: You can remove a focused node by pressing 'Delete'. You can remove the focused nodes and all following nodes (remove chain) by pressing 'ALT + Delete'. A focused node is displayed with an additional highlight around the node.
- new: Main Menu: 'Custom Choice Settings' available. You can add custom choices to the main menu (before the 'Exit' button). A custom choice will search for a game object in the scene and try to call a defined function on it. The call happens after the main menu is closed.
- new: Input Keys: 'Hold Time' setting available. When using input handling 'Hold' or 'Down', you can define the time the key has to be held to recognize the input.
- new: Inventory Settings: Item Collection: 'Auto Close' settings available. The item collection dialogue can automatically close after time.
- new: Combatants: The combatant's object variables can be initialized with default variables.
- new: Scene Objects: 'Object Variables' settings available. You can automatically add an 'Object Variable' component to a scene object and initialize them with default values.
- change: Editor: Events: The 'Close' button will now display a question dialogue if you really want to close the event.
- change: Status Effects: Reapplying a status effect (i.e. applying it again when it's already added) now also checks the hit chance.
- change: Inventory Settings: Item Collection: Playing an animation now uses Animation Types.
- fix: HUDs: 'Console' type HUDs don't throw an error when using 'All Console Types'.
- fix: Random Battle Area: Using a 'Battle Object' for the random battles blocked starting battles after the first battle.
- fix: Music: Playing the same music that is currently stored could sometimes result in playing from the stored time.


Version 2.0.3
- new: Editor: GUI Editor: The WYSIWYG editor allows editing HUDs.
- new: Editor: Updating events when saving or scanning for game variables in events can optionally only scan within a defind folder in the 'Assets' path.
- new: Editor: Status Development Curves: Creating a status development curve can now optionally use a curve instead of interpolation points.
- new: Abilities: 'Remove Turn' setting available. In 'Turn Based' battles, the target of the ability will be forced to skip a turn (if not yet performed).
- new: Items: 'Turn Based Order Changes' settings available. Like abilities, items can now change the turn order or remove the turn of a target in 'Turn Based' battles.
- new: Menu Screens: Equipment Part: Highlighting the 'Unequip' button will now also display preview values (for unequipping the equipment part).
- new: Status Effects: 'End Action' settings available. A status effect can optionally let the combatant perform an action when it ends. The action will be performed the next time the combatant can choose an action.
- new: Status Effects: 'No Turn Order Change' and 'No Turn Remove' settings available. Optionally grants immunity to turn order changes and removing a turn using abilities or items.
- new: HUDs: The new 'Turn Order' type HUD displays the current turn order of 'Turn Based' battles.
- new: HUDs: Navigation: 'Navigation' type HUD elements can display a background image.
- new: HUDs: Combatant: 'Combatant' type HUD status effect elements now allow adding multiple lables (similar to shortcut elements) to create more complex status effect information.
- new: HUDs: Combatant: 'Combatant' type HUD status effect elements can display the remaining time/turns of a status effect using % (without decimals, %1 (with 1 decimal) and %2 (with 2 decimals). Remaining turns are always displayed without decimals.
- new: HUDs: Tooltip: 'Status Effect' setting available in 'Tooltip' type HUDs. A tooltip can now be displayed when hovering the mouse above a status effect in a HUD.
- new: Combatants: 'Not Controllable' setting available. An 'AI Controlled' combatant can optionally be set to not controllable by the player. The combatant can't be selected as player using the player change keys.
- new: Languages: 'Initial Language' setting available. Set a language to be the initially selected language when starting the game.
- new: Damage Dealers: 'Environmental Damage' settings available. Set a damage dealer to be 'Always On' - damage will be dealt without firing an action first. You can use this for things like traps, hazardous areas or damage on contact with enemies.
- new: Damage Dealers: 'Reset Targets' settings available. When using 'One Time Damage' or 'One Target' you can use this to remove blocked targets after a defined amount of time, enabling additional damage by the damage dealer.
- new: GUI Boxes: 'Input Field Settings' available. Set spacing and alignment of input fields in dialogues.
- new: Event System: Dialogue Steps: 'Value Input Dialogue' step available. Displays a dialogue to input string, bool and float values and store them in game variables.
- new: Event System: Inventory Steps: 'Clear Inventory' step available. Removes everything (money, items, weapons and armors) from an inventory.
- new: Event System: Variable Steps: 'Clear Game Variables' step available. Removes all game variables (either local, global or object game variables).
- change: Abilities: 'Turn Based Order Changes' now also remove already fired actions that haven't yet been started. When using multi-turns, the turn value of the target will be changed instead of the turn order.
- change: Reflection: Call/check functions and check/change field/property exceptions now display the stack trace.
- fix: Move AI: 'Target Position Check' intervals of 0 now correctly update the target's position.
- fix: GUI Boxes: Selecting the last choice in a menu screen (e.g. equipment) which removes the choice wont cause an error any longer.
- fix: Event System: Animation Steps: 'Legacy Animation' now set's the layer and speed of animations correctly.
- fix: Node Editor: Adding unconnected nodes with the context menu will now place them correctly when scrolled down.
- fix: Player Group: Joining a combatant to the active player group after the player has already been spawned didn't spawn the new battle group member (requires 'Spawn Group' enabled in 'Game > Game Settings').


Version 2.0.2
- new: Editor: GUI Editor: The new GUI Editor allows editing GUI boxes in a WYSIWYG editor.
- new: Editor: You can open the ORK Framework editor using the hotkey 'CTRL + ALT + O'.
- new: Scene Wizard: You can open the ORK Scene Wizard using the hotkey 'CTRL + ALT + W'.
- new: Game Controls: Custom player/camera control scripts can now also be attached to child objects.
- new: Game Events: New event actor type 'Camera' available. Uses the event's camera as an actor.
- new: Event System: Movement Steps: 'Curve Move' step available. Move a game object using curves.
- new: Event System: Rotation Steps: 'Curve Rotation' step available. Rotate a game object using curves.
- new: Event System: Active Group Steps: 'Join Active Group' step allows adding a combatant group to the active player group.
- new: Abilities, Items: 'Use Screen Combatant' setting available. When using it's own combatant selection in menus, items and abilities can automatically be used on the current menu user without showing a combatant selection.
- new: Main Menu Settings: 'Set Start Group' setting available. You can use a Combatant Group as the player group at the start of a new game.
- change: GUI Boxes: The default settings for new GUI boxes have changed. The content/name box bounds have changed and the name box is now relative to the content box.
- fix: Event System: 'Use Center' setting in various steps wont cause objects to disappear when only a single target was used.
- fix: Battle System: Combatants dying when initialized (e.g. due to wrong setup, like 0 HP) wont cause an error.
- fix: Menu Screens: Hidden group members wont be displayed in 'Group Menu Parts' any longer.
- fix: Damage Dealers: Using an ability with the last available needed status value (e.g. MP) will no longer fail to activate the damage dealer.
- fix: Editor: Formulas: Testing formulas in the editor caused errors in some cases.
- fix: Status Effects: 'Auto Apply' caused an error in some cases.
- fix: GUI Boxes: The name box will is now displayed at the correct position when not relative to the content box with all anchor types.


Version 2.0.1
- new: Node Editor: Major update to the node editor. Button toolbar available at the top of the node display. Optional background grid display available. Searching the node list available.
- new: Editor: The variable list is automatically updated when saving the settings or an event. When saving the settings, only the settings will be scanned. When saving an event, only the event will be scanned.
- new: Items: 'Requirements' settings available. Using an item can depend on status requirements and variable conditions.
- new: Abilities: 'Requirements' settings now contain variable conditions. Using an ability can depend on variable conditions.
- new: Abilities, Items: 'Not On Self' setting available. When targetting allies or all combatants, the user can be excluded from being a target.
- new: Status Values: 'Critical Refresh Notification' and 'Critical Damage Notification' settings available. Optionally display different change notifications for critical hits.
- new: Event System: The new 'Image Steps' allow showing, fading and moving images on the screen. 'Show Image', 'Change Image Position', 'Change Image Color' and 'Remove Image' steps available.
- new: Event System: Variable Steps: 'Game Variable Fork' step available. Similar to 'Check Game Variable' step, but checks a single game variable for multiple values. The next step depends on which condition is valid.
- new: Event System: Status Steps: 'Status Fork' step available. The next step depends on which status requirement is valid.
- new: Event System: Status Steps: 'Change Status Value' step can optionally display change notifications as critical changes.
- new: Event System: Equipment Steps: 'Equipment Fork' step available. The next step depends on which weapon or armor is equipped on an equipment part.
- new: Event System: Fade Steps: 'Blink Object' step available. Starts/stops blinking a game object.
- new: Event System: Base Steps: 'Block Control Map' step available. Blocks/unblocks a selected control map or all control maps. A blocked control map can't be used.
- new: Event System: Dialogue Steps: 'Block HUD' step available. Blocks/unblocks a selected HUD or all HUDs. A blocked HUD wont be displayed.
- new: Event System: Function Steps: 'Change Time Factor' step available. Changes the time factor of Unity (everything in the game) or ORK Framework (things like battles and events only). You can use this to create slow motion effects.
- new: Event System: Function Steps: 'Check Component Enabled' step available. Checks if a component is enabled.
- new: Event System: Function Steps: 'Change Fields' step can now also change properties. Use the new 'Is Property' setting.
- new: Event System: Function Steps: 'Check Fields' step available. Checks the value of fields or properties of a component.
- new: Event System: Function Steps: 'Check Function' step available. Checks the return value of a function of a component.
- new: Event System: Movement Steps: 'Change Nav Mesh Target' step available. Sets the destination and speed of a Nav Mesh agent, or stops the agent.
- new: Formulas: Variable Steps: 'Game Variable Fork' step available. Similar to 'Check Game Variable' step, but checks a single game variable for multiple values. The next step depends on which condition is valid.
- new: Formulas: Combatant Steps: 'Status Fork' step available. The next step depends on which status requirement is valid.
- new: Logs: 'Invert Text Order' setting available. Optionally display log texts in inverted order (i.e. from high index to low index).
- new: Move AIs: 'Detect Only Leader' setting available. Detecting enemies can optionaly be limited to the group leader of an enemy group.
- new: Save Game Menu: Save Point: The 'Save' and 'Cancel' button are now optional (by default enabled). The 'Cancel' button can optionally override the default 'Cancel' button's content.
- new: Control Maps: 'Requirements' settings available for the whole control map and single control map keys. Using the control map or individual keys can optionally depend on status requirements and variable conditions.
- new: Battle AI: 'Check Distance' and 'Check Angle' steps available. Check possible targets upon distance and angle conditions. New 'Position Steps' group in step selection.
- new: Battle System: 'Stack Loot' setting available in all battle system types. Loot of the same kind will optionally be stacked. By default enabled.
- new: Turn Based Battles: 'Invert Turn Order' setting available. The turn order can optionally be inverted, i.e. sorted ascending, not descending (the combatant with the lowest value will have the first action).
- new: Turn Based Battles: 'Use Multi-Turns' setting available. A combatant can optionally perform multiple turns before another combatant had his turn. After a combatant performed his turn, his turn value will be reset to 0 and the turn value of all combatants will be increased. Available when 'Active Command' is enabled.
- new: Save Game Menu: 'Save Block States' setting available. The stated of blocked Input Keys, Control Maps and HUDs can be saved.
- new: Menu Screens: 'Menu Part Change Keys' settings available. Optionally use input keys to change the active menu part. You can only change to controlable parts (e.g. Inventory).
- change: Editor: Hotkeys: The navigation history hot keys now require the 'ALT' key to be pressed. Use 'ALT + Home' and 'ALT + End' to browse through the navigation history.
- change: Menu Screens: Items and abilities can't be used in a menu screen while the combatant is performing an action.
- fix: Menu Screens: Abilities and equipment displaying level up information will now display the correct inactive alpha value when inactive.
- fix: Event System: Function Steps: The 'Enable Component' step will now also enable/disable colliders, renderers, particle emitters and LOD groups.


Version 2.0.0
Initial release.

For changes to the beta versions, please visit http://orkframework.com.

