using System;
using KimHaiQuang.SharpDCIIDE.Domain.Data.DCIInfo;
using KimHaiQuang.SharpDCIIDE.Domain.Operation;

namespace KimHaiQuang.SharpDCIIDE.Domain.Reader.Marvin
{
    public class DCIMarvinContextReader : 
        ContextFileParsingContext.IDCIContextReader
    {
        public DCIMarvinContextReader(DCIContext contextFileModel)
        {
            throw new Exception("No implementation");
        }

        public DCIContext Read(string filePath)
        {
            throw new Exception("No implementation");
        }
    }
}
