// This is an event handler that checks to see if IE is running.
// If it is, then TestComplete terminates the process and runs the test
function GeneralEvents_OnStartTest(sender) {
  let IE = Sys.WaitProcess("iexplore");
  if (IE.Exists) {
    IE.Close();
  }
  else {
    Log.Message("IE is not currently in memory. Proceeding with test.");
  }
}
