﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IntraPositionMovementDetails12.  ISO2002 ID# _5Qz005NLEeWGlc8L7oPDIg.
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
public partial record IntraPositionMovementDetails12
     : IIsoXmlSerilizable<IntraPositionMovementDetails12>
{
    #nullable enable
    
    /// <summary>
    /// Identifications (account owner and/or account servicer) of the intra-position movement.
    /// </summary>
    public References51Choice_? Identification { get; init; } 
    /// <summary>
    /// Quantity of financial instrument effectively settled.
    /// </summary>
    public required FinancialInstrumentQuantity15Choice_ SettledQuantity { get; init; } 
    /// <summary>
    /// Quantity of financial instrument previously settled.
    /// </summary>
    public FinancialInstrumentQuantity15Choice_? PreviouslySettledQuantity { get; init; } 
    /// <summary>
    /// Quantity of financial instrument remaining to be settled.
    /// </summary>
    public FinancialInstrumentQuantity15Choice_? RemainingToBeSettledQuantity { get; init; } 
    /// <summary>
    /// Number identifying a securities sub-balance type (example restriction identification etc…).
    /// </summary>
    public GenericIdentification39? SecuritiesSubBalanceIdentification { get; init; } 
    /// <summary>
    /// Balance to which the securities were moved.
    /// </summary>
    public required SecuritiesBalanceType8Choice_ BalanceTo { get; init; } 
    /// <summary>
    /// Date and time at which the securities were moved.
    /// </summary>
    public required DateAndDateTimeChoice_ SettlementDate { get; init; } 
    /// <summary>
    /// Date/time securities become available for sale (if securities become unavailable, this specifies the date/time at which they will become available again).
    /// </summary>
    public DateAndDateTimeChoice_? AvailableDate { get; init; } 
    /// <summary>
    /// Specifies the type of corporate event.
    /// </summary>
    public CorporateActionEventType46Choice_? CorporateActionEventType { get; init; } 
    /// <summary>
    /// Value of the collateral available for the delivery settlement process at the account level.
    /// </summary>
    public AmountAndDirection55? CollateralMonitorAmount { get; init; } 
    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    public IsoRestrictedFINXMax350Text? InstructionProcessingAdditionalDetails { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init; } 
    
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
        if (Identification is References51Choice_ IdentificationValue)
        {
            writer.WriteStartElement(null, "Id", xmlNamespace );
            IdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SttldQty", xmlNamespace );
        SettledQuantity.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (PreviouslySettledQuantity is FinancialInstrumentQuantity15Choice_ PreviouslySettledQuantityValue)
        {
            writer.WriteStartElement(null, "PrevslySttldQty", xmlNamespace );
            PreviouslySettledQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RemainingToBeSettledQuantity is FinancialInstrumentQuantity15Choice_ RemainingToBeSettledQuantityValue)
        {
            writer.WriteStartElement(null, "RmngToBeSttldQty", xmlNamespace );
            RemainingToBeSettledQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecuritiesSubBalanceIdentification is GenericIdentification39 SecuritiesSubBalanceIdentificationValue)
        {
            writer.WriteStartElement(null, "SctiesSubBalId", xmlNamespace );
            SecuritiesSubBalanceIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "BalTo", xmlNamespace );
        BalanceTo.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "SttlmDt", xmlNamespace );
        SettlementDate.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AvailableDate is DateAndDateTimeChoice_ AvailableDateValue)
        {
            writer.WriteStartElement(null, "AvlblDt", xmlNamespace );
            AvailableDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CorporateActionEventType is CorporateActionEventType46Choice_ CorporateActionEventTypeValue)
        {
            writer.WriteStartElement(null, "CorpActnEvtTp", xmlNamespace );
            CorporateActionEventTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CollateralMonitorAmount is AmountAndDirection55 CollateralMonitorAmountValue)
        {
            writer.WriteStartElement(null, "CollMntrAmt", xmlNamespace );
            CollateralMonitorAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InstructionProcessingAdditionalDetails is IsoRestrictedFINXMax350Text InstructionProcessingAdditionalDetailsValue)
        {
            writer.WriteStartElement(null, "InstrPrcgAddtlDtls", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax350Text(InstructionProcessingAdditionalDetailsValue)); // data type RestrictedFINXMax350Text System.String
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static IntraPositionMovementDetails12 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
