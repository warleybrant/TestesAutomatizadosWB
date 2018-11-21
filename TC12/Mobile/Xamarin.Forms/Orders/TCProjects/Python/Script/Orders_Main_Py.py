# This example works with the sample Xamarin.Forms Orders application.
# You can find its source code in the following folder:
#    <TestComplete Samples>/Mobile/Xamarin.Forms/Orders/Orders/
# 
# BEFORE running the example:
#
#  1. Make certain that the compiled sample Android Orders application is located here: 
#   <TestComplete Samples>/Mobile/Xamarin.Forms/Orders/TCProjects/Apps/Orders.Orders-Signed.apk
#
#  2. Compile the sample iOS Orders application: 
#   * Compile the sample application on a Mac computer.
#   * Copy the compiled .ipa file to the following folder:
#        <TestComplete Samples>/Mobile/Xamarin.Forms/Orders/TCProjects/Apps/OrdersSample.ipa
#   * Check that the Orders item in the TestedApps collection contains 
#     a valid path to the .ipa file.
#  
#  3. Connect your Android or/and iOS device/devices to your computer.
#     After that, you can run the test project. The test project will deploy 
#     the tested .ipa or /and .apk file to the device(s) automatically.
#
# Enjoy!

from Orders_Xamarin_Forms_Py import *

def main():
  for i in range(Mobile.ChildCount):
    device = Mobile.Child(i)
    Mobile.SetCurrent(device.DeviceName, device.Index)  
  
    if device.OSType == "iOS":
      TestedApps.Orders_iOS.Run()
      ordersProcess = Mobile.Device().WaitProcess("OrdersSample", 10000)
    elif device.OSType == "Android":
      TestedApps.Orders_Android.Run()
      ordersProcess = Mobile.Device().WaitProcess("Orders.Orders", 10000)
    else:
      raise Exception("Platform [" + device.OSType + "] not supported")
      
    # Actions
    addNewOrder(ordersProcess)
    editOrder(ordersProcess, 'Susan McLaren')
    deleteOrder(ordersProcess, "John Black", device.OSType)
  
  if Mobile.ChildCount == 0:
    Log.Warning("No devices found.")
