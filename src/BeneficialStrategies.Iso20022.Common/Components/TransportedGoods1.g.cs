﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransportedGoods1.  ISO2002 ID# _SpnEn9p-Ed-ak6NoX_4Aeg_-1297466325.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Goods or services that are part of a commercial trade agreement.
/// </summary>
public partial record TransportedGoods1
     : IIsoXmlSerilizable<TransportedGoods1>
{
    #nullable enable
    
    /// <summary>
    /// Reference to the purchase order of the underlying transaction.
    /// </summary>
    public required DocumentIdentification7 PurchaseOrderReference { get; init; } 
    /// <summary>
    /// Information about the goods and/or services of a trade transaction.
    /// </summary>
    public IsoMax70Text? GoodsDescription { get; init; } 
    /// <summary>
    /// Information important for the users of the message/service, which cannot be captured in any other message component/element. For example: Warehouse number.
    /// </summary>
    public UserDefinedInformation1? BuyerDefinedInformation { get; init; } 
    /// <summary>
    /// Information important for the users of the message/service, which cannot be captured in any other message component/element. For example: Warehouse number.
    /// </summary>
    public UserDefinedInformation1? SellerDefinedInformation { get; init; } 
    
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
        writer.WriteStartElement(null, "PurchsOrdrRef", xmlNamespace );
        PurchaseOrderReference.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (GoodsDescription is IsoMax70Text GoodsDescriptionValue)
        {
            writer.WriteStartElement(null, "GoodsDesc", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(GoodsDescriptionValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        if (BuyerDefinedInformation is UserDefinedInformation1 BuyerDefinedInformationValue)
        {
            writer.WriteStartElement(null, "BuyrDfndInf", xmlNamespace );
            BuyerDefinedInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SellerDefinedInformation is UserDefinedInformation1 SellerDefinedInformationValue)
        {
            writer.WriteStartElement(null, "SellrDfndInf", xmlNamespace );
            SellerDefinedInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static TransportedGoods1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
