namespace ScheduleMe.Tab;

internal static class DBConnection
{
    static internal string databaseConnection = $"{GetBasePath()}\\ScheduleMe.db";

    static internal string GetBasePath()
    {
        return Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
    }

    /*
    static void DBConnectionTemplate()
    {
        // Use this for Note
        using (var noteDB = new LiteDatabase(DBConnection.databaseConnection)) // Open a connection
        {
            var notes = noteDB.GetCollection<Notes>("Note"); // Get the collection of object <Notes> in Note Document
            // "Notes" is the Object or DataType that you will store in "Note" Document
            // Replace the Object <Notes> with approriate Object that can store data

            // This is how you add an object to "Note" Document. Use Insert method of variables notes. That will automatically save it
            Notes note = new Notes(); // Create object
            note.NotesProperties = something; // assign value to object property
            timelines.Insert(note); // Save the object to the database

            // To retrieve tha data use the FindAll || FindById
            var notes = timelines.FindAll(); // notes will hold all the object that you insert
            or
            var note = timelines.FIndById(ObjectID); // note will hold the specific object that has the same ObjectID
                                                    // but you need to create a variable for a [BSON ID] ObjectID to an object to know thier ID

            // You can then retrieve the data you store to the object
            foreach (var Notes in  notes)
            {
                // Loop through a collection of object 
            }
            // or simply get the value to a single object like FIndById
            var something = note.NotesProperties;
            
            // Just like filestream, we have to ensure that the database is dispose after all this that is why we use using statement
            // Because we can't write or read the database in multiple process. One a time only
        }

        // In sumarry this is how I typically do it

        using (var noteConnection = new LiteDatabase(DBConnection.databaseConnection))
        {
            var noteDB = noteConnection.GetCollection<YourObject>("Note");
            var notes = noteDB.FindAll();

            // Do somehting here
        }
        OR
        using (var noteConnection = new LiteDatabase(DBConnection.databaseConnection))
        {
            var noteDB = noteConnection.GetCollection<YourObject>("Note");
            var notes = noteDB.FindById(ObjectId);

            // Do something here
        }
        // Create an object to hold you data. Datatypes can only hold a single data, Object is flexible
        // You cant just insert different data in DB and expecting to look for it so easily
    }*/
}
