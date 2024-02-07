﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ProcessingStatus98Choice.  ISO2002 ID# _xnOQMQarEe2phaVG0lYKTw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of status for the processing.
/// </summary>
[KnownType(typeof(ProcessingStatus98Choice.AcknowledgedAccepted))]
[KnownType(typeof(ProcessingStatus98Choice.AlreadyMatchedAndAffirmed))]
[KnownType(typeof(ProcessingStatus98Choice.DefaultAction))]
[KnownType(typeof(ProcessingStatus98Choice.Done))]
[KnownType(typeof(ProcessingStatus98Choice.ForcedRejection))]
[KnownType(typeof(ProcessingStatus98Choice.FullyExecutedConfirmationSent))]
[KnownType(typeof(ProcessingStatus98Choice.Future))]
[KnownType(typeof(ProcessingStatus98Choice.Generated))]
[KnownType(typeof(ProcessingStatus98Choice.InRepair))]
[KnownType(typeof(ProcessingStatus98Choice.NoInstruction))]
[KnownType(typeof(ProcessingStatus98Choice.OpenOrder))]
[KnownType(typeof(ProcessingStatus98Choice.PendingProcessing))]
[KnownType(typeof(ProcessingStatus98Choice.ReceivedAtIntermediary))]
[KnownType(typeof(ProcessingStatus98Choice.Rejected))]
[KnownType(typeof(ProcessingStatus98Choice.SettlementInstructionSent))]
[KnownType(typeof(ProcessingStatus98Choice.StandingInstruction))]
[KnownType(typeof(ProcessingStatus98Choice.TradingSuspendedByStockExchange))]
[KnownType(typeof(ProcessingStatus98Choice.Treated))]
[KnownType(typeof(ProcessingStatus98Choice.ProprietaryStatus))]
public abstract partial record ProcessingStatus98Choice_ : IIsoXmlSerilizable<ProcessingStatus98Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static ProcessingStatus98Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "AckdAccptd" => ProcessingStatus98Choice.AcknowledgedAccepted.Deserialize(elementWithPayload),
             "AlrdyMtchdAndAffrmd" => ProcessingStatus98Choice.AlreadyMatchedAndAffirmed.Deserialize(elementWithPayload),
             "DfltActn" => ProcessingStatus98Choice.DefaultAction.Deserialize(elementWithPayload),
             "Done" => ProcessingStatus98Choice.Done.Deserialize(elementWithPayload),
             "ForcdRjctn" => ProcessingStatus98Choice.ForcedRejection.Deserialize(elementWithPayload),
             "FullyExctdConfSnt" => ProcessingStatus98Choice.FullyExecutedConfirmationSent.Deserialize(elementWithPayload),
             "Futr" => ProcessingStatus98Choice.Future.Deserialize(elementWithPayload),
             "Gnrtd" => ProcessingStatus98Choice.Generated.Deserialize(elementWithPayload),
             "InRpr" => ProcessingStatus98Choice.InRepair.Deserialize(elementWithPayload),
             "NoInstr" => ProcessingStatus98Choice.NoInstruction.Deserialize(elementWithPayload),
             "OpnOrdr" => ProcessingStatus98Choice.OpenOrder.Deserialize(elementWithPayload),
             "PdgPrcg" => ProcessingStatus98Choice.PendingProcessing.Deserialize(elementWithPayload),
             "RcvdAtIntrmy" => ProcessingStatus98Choice.ReceivedAtIntermediary.Deserialize(elementWithPayload),
             "Rjctd" => ProcessingStatus98Choice.Rejected.Deserialize(elementWithPayload),
             "SttlmInstrSnt" => ProcessingStatus98Choice.SettlementInstructionSent.Deserialize(elementWithPayload),
             "StgInstr" => ProcessingStatus98Choice.StandingInstruction.Deserialize(elementWithPayload),
             "TradgSspdByStockXchg" => ProcessingStatus98Choice.TradingSuspendedByStockExchange.Deserialize(elementWithPayload),
             "Trtd" => ProcessingStatus98Choice.Treated.Deserialize(elementWithPayload),
             "PrtrySts" => ProcessingStatus98Choice.ProprietaryStatus.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid ProcessingStatus98Choice choice.")
        };
    }
}
