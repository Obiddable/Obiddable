---
name: QA Version Test
about: QA Version Test
title: QA Testing (v{major}.{minor}.0.0)
labels: ''
assignees: ''

---

## QA

### Choose Data Source...

* [ ] Local SQLite > Browse
  * [ ] Create new? Yes, Prompts to choose new location
  * [ ] No, Prompts to choose existing 
    * [ ] Choosing fake location gives error
  * [ ] Cancel, Goes back
* [ ] Microsoft SQL Server
  * [ ] Blank gives error
* [ ] Click First Chancel says to quit
   * [ ] Yes, does not quit
   * [ ] No, Does quit 
* [ ] Save Changes works

### Configuration Form

* [ ] Fills user documents for reports and exports
* [ ] epplus licensing  

### Global UI

* [ ] Exports Folder
* [ ] Reports Folder
* [ ] Refresh Screen
* [ ] Config
   * [ ] Set Reports Folder
   * [ ] Set Exports Folder
   * [ ] Options:
      * [ ] Allow Bid Deletions
      * [ ] Suppress File Path Selections on Saving
      * [ ] Automatically Open All Export Files
      * [ ] Automatically Open All Generated Reports
      * [ ] Timestamp All Exports  
* [ ] Help 

### Bid Maintenance 

* [ ] Can create bid 
* [ ] Can change bid title
* [ ] Can delete bid after changing setting
* [ ] Actions 
  * [ ] Export Bid
  * [ ] Roll Bid
  * [ ] Duplicate Bid
  * [ ] Clear Items
  * [ ] Clear Requestors
  * [ ] Clear Vendors 

### Bid Navigation

* [ ] Looks Correct
* [ ] Bid Navigation
   * [ ] Run Reports
      * [ ] Bid Items List Report
      * [ ] Bid Requestors Requested Quantities Report
      * [ ] Bid Requests Detail Report
      * [ ] Bid Requests Summary Report
      * [ ] Price Override Report
      * [ ] Expenditures by Requestor Report
      * [ ] Vendor Specifications Report
      * [ ] Vendor Detail Report
      * [ ] Vendor Detail Report (Elected Only)
      * [ ] Vendor Summary Report
      * [ ] No Response Items Report
      * [ ] Election Confirmation Sheet Report
      * [ ] Elected Quantities Discrepancy Report
      * [ ] Bid Tally Report
      * [ ] Bid Summary Report
      * [ ] Detailed Distribution Report

### Items

* [ ] Actions
  * [ ] Update All Item Prices
  * [ ] Reset All Item Prices
  * [ ] Import Items From CSV
  * [ ] Export All Items To CSV
  * [ ] Generate Items Import Template to CSV
* [ ] Add Item
* [ ] Edit Item
   * [ ] Last Order Price 
* [ ] Delete Item THIS NEEDS FIXED, DELETE BUTTON DOESNT WORK, key does? 

### Requesting

* [ ] Requestors
   * [ ] Import Requestors From CSV
   * [ ] Export All Requestors To CSV
   * [ ] Generate Requestor Import Template To Csv
   * [ ] Generate Blank Requests For All Requestors to Excel
   * [ ] Selected > Open Requests
   * [ ] Selected > Clear Requests
   * [ ] Add Requestor
   * [ ] Edit Requestor
   * [ ] Delete Requestor
* [ ] Request 
   * [ ] Add Request
   * [ ] Edit Request
   * [ ] Delete Request
   * [ ] Generate Blank Request to Csv
   * [ ] Generate Blank Request to Excel
   * [ ] Selected 
      * [ ] Clear Requested Items
      * [ ] Import Request From Csv
      * [ ] Import Request From Excel
      * [ ] Export Request to Csv

### Vendor Responses

* [ ] Actions 
  * [ ] Generate Blank Vendor REsponse o CSV
  * [ ] Generate Blank Vendor REsponse to Excel
  * [ ] Selected > Clear Response Items
  * [ ] Selected > Import Vendor Response From CSV
  * [ ] Selected > Import Vendor Response from Excel
  * [ ] Selected > Export Vendor Response To CSV
* [ ] Add
* [ ] Edit
* [ ] Delete


### Elections

* [ ] Elections
   * [ ] Actions
      * [ ] Run Low Bid On All Items
      * [ ] Run Low Bid On Unselected Items
      * [ ] Clear All Elections
      * [ ] Import Elections from CSV
      * [ ] Export All Elections to CSV
      * [ ] Selected > Clear Election
  * [ ] Edit
     * [ ] Clear Button
     * [ ] Select one
     * [ ] Elect one and set a reason for it     

### Purchasing

* [ ] Purchase Order Maintenance 
   * [ ] Actions
      * [ ] Generate Purchase Orders
      * [ ] Selected > Export Purchase Order to Excel
