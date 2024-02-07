﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RequestDetails11.  ISO2002 ID# _uQtNwQ4EEeKN_Y-2Awiamw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the settlement condition modification request.
/// </summary>
public partial record RequestDetails11
     : IIsoXmlSerilizable<RequestDetails11>
{
    #nullable enable
    
    /// <summary>
    /// References of the transaction for which the securities settlement condition modification is requested.
    /// </summary>
    public required References9 Reference { get; init; } 
    /// <summary>
    /// Condition for automatic borrowing.
    /// </summary>
    public AutomaticBorrowing2Choice_? AutomaticBorrowing { get; init; } 
    /// <summary>
    /// Specifies whether the instruction due to expire is confirmed for settlement.
    /// </summary>
    public IsoYesNoIndicator? RetainIndicator { get; init; } 
    /// <summary>
    /// Specifies the type of linkage requested.
    /// </summary>
    public LinkageType1Choice_? Linkage { get; init; } 
    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    public PriorityNumeric1Choice_? Priority { get; init; } 
    /// <summary>
    /// Specifies another type of processing change request.
    /// </summary>
    public GenericIdentification20? OtherProcessing { get; init; } 
    /// <summary>
    /// Specifies whether partial settlement is allowed.
    /// </summary>
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; } 
    /// <summary>
    /// Specifies whether the settlement transaction is to be settled through an RTGS or a non RTGS system.
    /// </summary>
    public SecuritiesRTGS1Choice_? SecuritiesRTGS { get; init; } 
    /// <summary>
    /// Specifies whether the transaction is on hold/blocked/frozen.
    /// </summary>
    public HoldIndicator4? HoldIndicator { get; init; } 
    /// <summary>
    /// Specifies the matching processing change requested.
    /// </summary>
    public MatchingDenied1Choice_? MatchingDenial { get; init; } 
    /// <summary>
    /// Specifies that the transaction is requested to be unilaterally split.
    /// </summary>
    public UnilateralSplit1Choice_? UnilateralSplit { get; init; } 
    /// <summary>
    /// Information regarding the linkage requested.
    /// </summary>
    public Linkages27? Linkages { get; init; } 
    
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
        writer.WriteStartElement(null, "Ref", xmlNamespace );
        Reference.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AutomaticBorrowing is AutomaticBorrowing2Choice_ AutomaticBorrowingValue)
        {
            writer.WriteStartElement(null, "AutomtcBrrwg", xmlNamespace );
            AutomaticBorrowingValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RetainIndicator is IsoYesNoIndicator RetainIndicatorValue)
        {
            writer.WriteStartElement(null, "RtnInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(RetainIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (Linkage is LinkageType1Choice_ LinkageValue)
        {
            writer.WriteStartElement(null, "Lkg", xmlNamespace );
            LinkageValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Priority is PriorityNumeric1Choice_ PriorityValue)
        {
            writer.WriteStartElement(null, "Prty", xmlNamespace );
            PriorityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OtherProcessing is GenericIdentification20 OtherProcessingValue)
        {
            writer.WriteStartElement(null, "OthrPrcg", xmlNamespace );
            OtherProcessingValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PartialSettlementIndicator is SettlementTransactionCondition5Code PartialSettlementIndicatorValue)
        {
            writer.WriteStartElement(null, "PrtlSttlmInd", xmlNamespace );
            writer.WriteValue(PartialSettlementIndicatorValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (SecuritiesRTGS is SecuritiesRTGS1Choice_ SecuritiesRTGSValue)
        {
            writer.WriteStartElement(null, "SctiesRTGS", xmlNamespace );
            SecuritiesRTGSValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (HoldIndicator is HoldIndicator4 HoldIndicatorValue)
        {
            writer.WriteStartElement(null, "HldInd", xmlNamespace );
            HoldIndicatorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MatchingDenial is MatchingDenied1Choice_ MatchingDenialValue)
        {
            writer.WriteStartElement(null, "MtchgDnl", xmlNamespace );
            MatchingDenialValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UnilateralSplit is UnilateralSplit1Choice_ UnilateralSplitValue)
        {
            writer.WriteStartElement(null, "UnltrlSplt", xmlNamespace );
            UnilateralSplitValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Linkages is Linkages27 LinkagesValue)
        {
            writer.WriteStartElement(null, "Lnkgs", xmlNamespace );
            LinkagesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static RequestDetails11 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
