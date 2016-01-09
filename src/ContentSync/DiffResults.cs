﻿using System.Collections.Generic;

namespace GuiLabs.FileUtilities
{
    public class FolderDiffResults
    {
        public IEnumerable<string> LeftOnlyFiles { get; private set; }
        public IEnumerable<string> IdenticalFiles { get; private set; }
        public IEnumerable<string> ChangedFiles { get; private set; }
        public IEnumerable<string> RightOnlyFiles { get; private set; }

        public FolderDiffResults(
            IEnumerable<string> leftOnlyFiles,
            IEnumerable<string> identicalFiles,
            IEnumerable<string> changedFiles,
            IEnumerable<string> rightOnlyFiles)
        {
            LeftOnlyFiles = leftOnlyFiles;
            IdenticalFiles = identicalFiles;
            ChangedFiles = changedFiles;
            RightOnlyFiles = rightOnlyFiles;
        }
    }
}
