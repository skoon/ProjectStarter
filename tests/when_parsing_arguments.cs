using System;
using Xunit;
using ProjectStarter;

namespace ProjectStarter_tests {

    public class when_parsing_arguments {
        
        public ArgParser parser;
        public when_parsing_arguments() {
            parser = new ArgParser(new string[] {"test"}, new MockFileSystem());
        }
    
        [Fact]
        public void the_command_property_should_be_set() {
            Assert.NotNull(parser.Command);
        }

        public void the_command_property_should_be_the_correct_concrete_type() {
           Assert.IsType(typeof(NewProject), parser.Command); 
        }
    }
}
