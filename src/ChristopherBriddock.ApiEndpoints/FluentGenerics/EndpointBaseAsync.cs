using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ChristopherBriddock.ApiEndpoints;

/// <summary>
/// A base class for an endpoint that accepts parameters.
/// </summary>
public static class EndpointBaseAsync
{
    public static class WithRequest<TRequest>
    {
        public static class WithQuery<TQuery>
        {
            public abstract class WithResult<TResponse> : EndpointBase
            {
                public abstract Task<TResponse> HandleAsync(
                    TRequest request, TQuery param,
                    CancellationToken cancellationToken = default
                );
            }
            public abstract class WithoutResult : EndpointBase
            {
                public abstract Task HandleAsync(
                    TRequest request, TQuery param,
                    CancellationToken cancellationToken = default
                );
            }
            public abstract class WithActionResult<TResponse> : EndpointBase
            {
                public abstract Task<ActionResult> HandleAsync(
                    TRequest request,TResponse response,
                    CancellationToken cancellationToken = default
                );
            }
            public abstract class WithActionResult : EndpointBase
            {
                public abstract Task<ActionResult> HandleAsync(
                    TRequest request, TQuery param,
                    CancellationToken cancellationToken = default
                );
            }
        }
        public static class WithoutQuery
        {
            public abstract class WithResult<TResponse> : EndpointBase
            {
                public abstract Task<TResponse> HandleAsync(
                    TRequest request,
                    CancellationToken cancellationToken = default
                );
            }
            public abstract class WithoutResult : EndpointBase
            {
                public abstract Task HandleAsync(
                    TRequest request,
                    CancellationToken cancellationToken = default
                );
            }
            public abstract class WithActionResult<TResponse> : EndpointBase
            {
                public abstract Task<ActionResult<TResponse>> HandleAsync(
                    TRequest request,
                    CancellationToken cancellationToken = default
                );
            }
            public abstract class WithActionResult : EndpointBase
            {
                public abstract Task<ActionResult> HandleAsync(
                    TRequest request,
                    CancellationToken cancellationToken = default
                );
            }
            public abstract class WithAsyncEnumerableResult<T> : EndpointBase
            {
                public abstract IAsyncEnumerable<T> HandleAsync(
                  TRequest request,
                  CancellationToken cancellationToken = default
                );
            }
        }
    }

    public static class WithoutRequest
    {
        public abstract class WithResult<TResponse> : EndpointBase
        {
            public abstract Task<TResponse> HandleAsync(
                CancellationToken cancellationToken = default
            );
        }

        public abstract class WithoutResult : EndpointBase
        {
            public abstract Task HandleAsync(
                CancellationToken cancellationToken = default
            );
        }

        public abstract class WithActionResult<TResponse> : EndpointBase
        {
            public abstract Task<ActionResult<TResponse>> HandleAsync(
                CancellationToken cancellationToken = default
            );
        }

        public abstract class WithActionResult : EndpointBase
        {
            public abstract Task<ActionResult> HandleAsync(
                CancellationToken cancellationToken = default
            );
        }

        public abstract class WithAsyncEnumerableResult<T> : EndpointBase
        {
            public abstract IAsyncEnumerable<T> HandleAsync(
              CancellationToken cancellationToken = default
            );
        }
    }
}
