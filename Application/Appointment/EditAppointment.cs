using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using MediatR;
using Persistence;

namespace Application.Appointment
{
    public class EditAppointment
    {
        public class Command : IRequest
        {
            public Appointments Appointment { get; set; }

            public class Handler : IRequestHandler<Command>
            {
                private readonly DataContext _context;
                private readonly IMapper _mapper;
                public Handler(DataContext context, IMapper mapper)
                {
                    _mapper = mapper;
                    _context = context;
                }

                public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
                {
                    var appointment = await _context.Appointments.FindAsync(request.Appointment.AppointmentId);

                    _mapper.Map(request.Appointment, appointment);

                    await _context.SaveChangesAsync();

                    return Unit.Value;
                }

            
            }
        }
    }
}