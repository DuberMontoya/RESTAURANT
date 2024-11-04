using System.Runtime.Serialization;

namespace TDDSI.RESTAURANT.BACKEND.Infrastructure.PostgreSql.Exceptions;
public class TimeoutErrorException : Exception {
    public TimeoutErrorException() {
    }

    public TimeoutErrorException( string? message ) : base( message ) {
    }

    public TimeoutErrorException( string? message, Exception? innerException ) : base( message, innerException ) {
    }

    protected TimeoutErrorException( SerializationInfo info, StreamingContext context ) {
    }
}