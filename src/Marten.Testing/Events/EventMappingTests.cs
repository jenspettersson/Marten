using Marten.Events;
using Shouldly;
using Xunit;

namespace Marten.Testing.Events
{
    public class EventMappingTests
    {
        [Fact]
        public void event_name_for_event_type()
        {
            var mapping = new EventMapping(new AggregateStorage<Quest>(), typeof(MembersJoined));

            mapping.EventTypeName.ShouldBe("members_joined");
        }
    }
}