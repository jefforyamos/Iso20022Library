﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IntraPositionDetails46.  ISO2002 ID# _zQw0kaOAEeeDTpy0mhI4TQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the intra-position movement.
/// </summary>
public partial record IntraPositionDetails46
     : IIsoXmlSerilizable<IntraPositionDetails46>
{
    #nullable enable
    
    /// <summary>
    /// Quantity of financial instrument effectively settled.
    /// </summary>
    public required FinancialInstrumentQuantity1Choice_ SettledQuantity { get; init; } 
    /// <summary>
    /// Number identifying a Securities Sub balance Type for example restriction identification.
    /// </summary>
    public GenericIdentification37? SecuritiesSubBalanceIdentification { get; init; } 
    /// <summary>
    /// Value of the collateral available for the delivery settlement process at the account level.
    /// </summary>
    public AmountAndDirection44? CollateralMonitorAmount { get; init; } 
    /// <summary>
    /// Quantity of financial instrument previously settled.
    /// </summary>
    public FinancialInstrumentQuantity1Choice_? PreviouslySettledQuantity { get; init; } 
    /// <summary>
    /// Quantity of financial instrument remaining to be settled.
    /// </summary>
    public FinancialInstrumentQuantity1Choice_? RemainingToBeSettledQuantity { get; init; } 
    /// <summary>
    /// Date and time at which the securities were moved.
    /// </summary>
    public required DateAndDateTime2Choice_ SettlementDate { get; init; } 
    /// <summary>
    /// Date/time securities become available for sale (if securities become unavailable, this specifies the date/time at which they will become available again).
    /// </summary>
    public DateAndDateTime2Choice_? AvailableDate { get; init; } 
    /// <summary>
    /// Specifies the type of corporate event.
    /// </summary>
    public CorporateActionEventType73Choice_? CorporateActionEventType { get; init; } 
    /// <summary>
    /// Balance from which the securities are moving.
    /// </summary>
    public required SecuritiesSubBalanceTypeAndQuantityBreakdown3 BalanceFrom { get; init; } 
    /// <summary>
    /// Balance to which the securities are moving.
    /// </summary>
    public required SecuritiesSubBalanceTypeAndQuantityBreakdown3 BalanceTo { get; init; } 
    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    public IsoMax350Text? InstructionProcessingAdditionalDetails { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "SttldQty", xmlNamespace );
        SettledQuantity.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SecuritiesSubBalanceIdentification is GenericIdentification37 SecuritiesSubBalanceIdentificationValue)
        {
            writer.WriteStartElement(null, "SctiesSubBalId", xmlNamespace );
            SecuritiesSubBalanceIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CollateralMonitorAmount is AmountAndDirection44 CollateralMonitorAmountValue)
        {
            writer.WriteStartElement(null, "CollMntrAmt", xmlNamespace );
            CollateralMonitorAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PreviouslySettledQuantity is FinancialInstrumentQuantity1Choice_ PreviouslySettledQuantityValue)
        {
            writer.WriteStartElement(null, "PrevslySttldQty", xmlNamespace );
            PreviouslySettledQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RemainingToBeSettledQuantity is FinancialInstrumentQuantity1Choice_ RemainingToBeSettledQuantityValue)
        {
            writer.WriteStartElement(null, "RmngToBeSttldQty", xmlNamespace );
            RemainingToBeSettledQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SttlmDt", xmlNamespace );
        SettlementDate.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AvailableDate is DateAndDateTime2Choice_ AvailableDateValue)
        {
            writer.WriteStartElement(null, "AvlblDt", xmlNamespace );
            AvailableDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CorporateActionEventType is CorporateActionEventType73Choice_ CorporateActionEventTypeValue)
        {
            writer.WriteStartElement(null, "CorpActnEvtTp", xmlNamespace );
            CorporateActionEventTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "BalFr", xmlNamespace );
        BalanceFrom.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "BalTo", xmlNamespace );
        BalanceTo.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (InstructionProcessingAdditionalDetails is IsoMax350Text InstructionProcessingAdditionalDetailsValue)
        {
            writer.WriteStartElement(null, "InstrPrcgAddtlDtls", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(InstructionProcessingAdditionalDetailsValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
    }
    public static IntraPositionDetails46 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
