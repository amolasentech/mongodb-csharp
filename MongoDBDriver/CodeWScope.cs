
using System;

namespace MongoDB.Driver
{
    
    
    public class CodeWScope : Code
    {
        private Document scope;
        public Document Scope {
            get {return scope;}
            set {scope = value;}
        }
        
        public CodeWScope(){}

        public CodeWScope(String code, Document scope){
            this.Value = code;
            this.Scope = scope;
        }
    }
}
