using System.Text.Json;

namespace Autommand.Serialization.Json;

/// <summary>
/// Todo: Need more failing cases.
/// </summary>
public abstract class JsonAutommandSerializerTests
{
    readonly IAutommandSerializer serializer =
        new JsonAutommandSerializer( new( JsonSerializerOptions.Default ) );

    record SimpleCommand( Guid Id );

    public sealed class Deserialize : JsonAutommandSerializerTests
    {
        [Test]
        [Arguments( "" )] // empty
        [Arguments( "blah" )] // not json
        [Arguments( """{ "Id": "not-a-guid" }""" )] // invalid guid]
        public void ShouldFailWhenNotJson( string serializedCommand )
        {
            Assert.Throws<AutommandSerializationException>( () =>
                serializer.Deserialize<SimpleCommand>( serializedCommand ) );
        }

        [Test]
        public async Task ShouldSucceedWhenValidJson()
        {
            SimpleCommand command = new(Guid.NewGuid() );
            string serializedCommand = serializer.Serialize( command );

            SimpleCommand deserializedCommand = serializer.Deserialize<SimpleCommand>( serializedCommand );
            await Assert.That( deserializedCommand ).IsEqualTo( command );
        }
    }
}
