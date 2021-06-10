using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Appointments
{
    public class AppointmentsDetails
    {
        public class Query : IRequest<Appointment>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Appointment>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;

            }
            public async Task<Appointment> Handle(Query request, CancellationToken cancellationToken)
            {
                    return await _context.Appointments.FindAsync(request.Id);

            }
        }
    }
}