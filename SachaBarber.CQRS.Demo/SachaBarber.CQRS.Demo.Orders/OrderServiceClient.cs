﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SachaBarber.CQRS.Demo.Orders.Commands;

namespace SachaBarber.CQRS.Demo.Orders
{
    public partial class OrderServiceClient :
        System.ServiceModel.ClientBase<IOrderService>, IOrderService
    {

        public OrderServiceClient()
        {
        }

        public OrderServiceClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public OrderServiceClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public OrderServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public OrderServiceClient(System.ServiceModel.Channels.Binding binding,
            System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        public System.Threading.Tasks.Task<bool> SendCommand(Command command)
        {
            return base.Channel.SendCommand(command);
        }
    }
}