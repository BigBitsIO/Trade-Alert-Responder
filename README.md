# Trade Alert Responder
![Trade Alert Responder](https://i.imgur.com/Vm7ap3b.png)
## What is Trade Alert Responder?
Trade Alert Responder is a .NET Winforms application written in C# designed to allow for a modular approach at finding and respdonding to trade alerts.  While the application was originally designed specifically for trading alerts it can be modified to work for any kind of alert and respond in kind with any kind of action.
## Explained Simply
Simply put, the application allows you to scan for trading alerts based on your settings and then act on those alerts however you have selected.
## Workflow
There is a very simple workflow to operating the application.
### Configure Settings
You will need to configure an "Alert Scanner" with settings in order to scan for alerts, as well as configure settings for selected "Alert Action" plugins to act on alerts.
### Scan For Alerts
![Alert Scanning Plugins](https://i.imgur.com/ckrRQB8.png)
Bring up the Alert Scanning tab of the application, choose the Alert Scanner you would like to use and hit the "Scan" button to begin scanning for alerts.  Any alerts found by the alert scanner will be added to the alerts tab.
### Find Alerts
To see all alerts found by the application you can go to the Alerts tab of the application.  The Alert Scanner plugin responsible for the alert should fill in any data relative to the alert you might need (with some configuration most likely).  Once alerts have found there way to the Alerts tab in the data table they will also trigger code to react to the alert, aka Alert Actions.
### Act on Alerts
![Alert Action Plugins](https://i.imgur.com/dwmAREy.png)
Alert Actions are enabled and disabled in the settings tab of the application.  For each alert found by the application an Alert Action for each Alert Action Plugin will be executed based on the Alert Action Plugin's own settings.
## Plugin Model
Alert Scanning and Alert Actions are designed based on a "modular" or "plugin" type system allow for the application to be extended upon for third party plugins to be allowed.
### Alert Scanning Plugins
Alert Scanning Plugins are responsible for scanning for alerts.  Alerts found by the scanners are sent to the Alerts tab of the application and each alert is the acted upon by Alert Action Plugins.
### Alert Action Plugins
Alert Action Plugins are responsible for responding to new alerts with actions.  Examples include posting to Twitter or Discord (with some configuration).  All alerts will act with all enabled Alert Action Plugins.
