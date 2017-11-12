using Cosmos.System.FileSystem;

namespace OSLibrary.IO
{
    public static class OSFileSystem
    {
        public static CosmosVFS FS = createFS();

        private static CosmosVFS createFS()
        {
            CosmosVFS vfs = new CosmosVFS();
            vfs.Initialize();
            return vfs;
        }

    }
}
