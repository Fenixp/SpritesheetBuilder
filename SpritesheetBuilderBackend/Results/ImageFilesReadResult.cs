using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpritesheetBuilderBackend.Results
{
    public class ImageFilesReadResult
    {
        private List<string> _errors = new List<string>();
        private List<string> _warnings = new List<string>();

        public void AddError(string errorMessage)
        {
            _errors.Add(errorMessage);
        }

        public void AddWarning(string warningMessage)
        {
            _warnings.Add(warningMessage);
        }

        public IEnumerable<string> Errors
        {
            get
            {
                return _errors;
            }
        }

        public IEnumerable<string> Warnings
        { 
            get
            {
                return _warnings;
            }
        }

        public bool HasErrors
        { 
            get
            {
                return _errors.Any();
            }
        }

        public bool HasWarnings
        {
            get
            {
                return _warnings.Any();
            }
        }
    }
}
