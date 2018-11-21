#  This test shows how to simulate user actions on .NET applications.
# 
#  It runs a C# tested app, loads orders from a file,
#  edits an order, creates a new order, and closes the tested app.

# The main test function
def main():
  process = runApplication()
  changeRecord(process)
  addRecord(process)
  close(process)

# Run the tested application
def runApplication():
  return TestedApps.orders.Run()

# Close the tested application without saving changes
def close(process):
  mainForm = process.WinFormsObject('MainForm')
  
  # Close the application
  mainForm.Close(0)
  
  # Answer "No" to the question on saving changes
  msgBox = process.Window('#32770', 'Confirmation')
  if msgBox.Exists:
    msgBox.Window('Button', '&No').ClickButton()
  
  # Wait until the Orders process terminates
  while process.Exists:
    Delay(100)

# Edit an order
def changeRecord(process):
  mainForm = process.WaitWinFormsObject('MainForm', 30000)
  toolBar = mainForm.WinFormsObject('ToolBar')
  
  # Click the "Open" toolbar button
  toolBar.ClickItem(1, False)
  
  # Load orders from a file via the Open File dialog
  openDlg = process.Window('#32770', 'Open')
  openDlg.OpenFile(Project.Path + '..\\MyTable.tbl')
  
  # Select the "Samuel Clemens" order 
  mainForm.WinFormsObject('OrdersView').ClickItem('Samuel Clemens', 0)
  
  # Click the "Edit" toolbar item
  toolBar.ClickItem(5, False)
  
  # Change order data 
  orderDlg = process.WinFormsObject('OrderForm') 
  orderDlg.WinFormsObject('Group').WinFormsObject('ProductNames').ClickItem('FamilyAlbum')
  orderDlg.WinFormsObject('Group').WinFormsObject('CardNo').SetText('123123123123')
  
  # Save changes
  orderDlg.WinFormsObject('ButtonOK').ClickButton()

# Create a new order
def addRecord(process):
  mainForm = process.WinFormsObject('MainForm')
  toolBar = mainForm.WinFormsObject('ToolBar')
  
  # Add a new order
  toolBar.ClickItem(4, False)

  # Enter new order details
  orderDlg = process.WinFormsObject('OrderForm') 
  orderDlg.WinFormsObject('Group').WinFormsObject('ProductNames').ClickItem('ScreenSaver')
  orderDlg.WinFormsObject('Group').WinFormsObject('Quantity').wValue = '2'
  orderDlg.WinFormsObject('Group').WinFormsObject('Date').wDate = '11/02/1999'
  orderDlg.WinFormsObject('Group').WinFormsObject('Customer').SetText('David Waters')
  orderDlg.WinFormsObject('Group').WinFormsObject('Street').SetText('3, Music Street')
  orderDlg.WinFormsObject('Group').WinFormsObject('City').SetText('Liverpool')
  orderDlg.WinFormsObject('Group').WinFormsObject('State').SetText('Great Britain')
  orderDlg.WinFormsObject('Group').WinFormsObject('MasterCard').ClickButton()
  orderDlg.WinFormsObject('Group').WinFormsObject('CardNo').SetText('1357902468')
  orderDlg.WinFormsObject('Group').WinFormsObject('ExpDate').wDate = '03/03/2008'
  
  # Save changes
  orderDlg.WinFormsObject('ButtonOK').ClickButton()
  