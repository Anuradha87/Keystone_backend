using System.ComponentModel;

namespace Keystone.Domain.Entities;

public enum DeliveryMethod
{
    [Description("Klassrum")]
    Classroom,
    [Description("Distans")]
    Distance,
    [Description("Distans med träffar")]
    DistanceAndClassroom
}