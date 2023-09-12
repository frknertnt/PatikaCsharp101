using StaffApp;

Staff P1 = new Staff();
P1.Name = "Furkan";
P1.Lastname = "Ertantu";
P1.Emailaddress = "furkan.ertantu";
P1.Gender = 717770001; // Ms 717770002 - Mrs

Staff P2 = new Staff();
P2.Name = "Gürkan";
P2.Lastname = "Atik";
P2.Emailaddress = "gurkan.atik";
P2.Gender = 717770001; // Ms 717770002 - Mrs



Helper.SendEmail("hr@myfirm.com", "New Personal Information", P1.Name + P1.Lastname);
Helper.SendEmail("hr@myfirm.com", "New Personal Information", P1.Name + P1.Lastname);
