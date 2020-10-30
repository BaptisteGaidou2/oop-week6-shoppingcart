using System;
using System.Collections.Generic;
using System.Text;

namespace PriorityCall
{
    public class CallCenter
    {
        private int _counter = 0;
        public PriorityQueue<IncomingCall> Calls { get; private set; }
        public CallCenter()
        {
            Calls = new PriorityQueue<IncomingCall>();
        }
        public void Call(int _ClientId,int priority)
        {
            IncomingCall peopleCalling = new IncomingCall { Id = _counter++, ClientId = _ClientId, CallTime = DateTime.Now };
            Calls.Enqueue(peopleCalling,priority);
        }
        public IncomingCall Answer(string consultant)
        {
            if (Calls.Count() > 0)
            {
                IncomingCall callAnswering = Calls.Dequeue();
                callAnswering.Consultant = consultant;
                callAnswering.StartTime = DateTime.Now;
                return callAnswering;
            }
            return null;
        }
        public void End(IncomingCall call)
        {
            call.EndTime = DateTime.Now;
        }
    }
}