using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace Nethereum.Commerce.Contracts.WalletBuyer.ContractDefinition
{


    public partial class WalletBuyerDeployment : WalletBuyerDeploymentBase
    {
        public WalletBuyerDeployment() : base(BYTECODE) { }
        public WalletBuyerDeployment(string byteCode) : base(byteCode) { }
    }

    public class WalletBuyerDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "608060405234801561001057600080fd5b506040516117ae3803806117ae83398101604081905261002f9161009d565b600080546001600160a01b03191633178082556040516001600160a01b039190911691907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e0908290a3600380546001600160a01b0319166001600160a01b03929092169190911790556100cb565b6000602082840312156100ae578081fd5b81516001600160a01b03811681146100c4578182fd5b9392505050565b6116d4806100da6000396000f3fe608060405234801561001057600080fd5b50600436106101005760003560e01c8063abefab8711610097578063c8d303f811610066578063c8d303f8146101fc578063cb4c86b71461020f578063f2fde38b14610217578063f3ad65f41461022a57610100565b8063abefab87146101b9578063c016d9b6146101ce578063c076cfbf146101d6578063c76ea978146101e957610100565b8063802706cb116100d3578063802706cb146101765780638da5cb5b146101895780638f32d59b1461019e57806391aa0f30146101a657610100565b8063150e99f9146101055780634f0dfe5b1461011a5780636b00e9d81461012d5780636fee6fec14610156575b600080fd5b610118610113366004610c51565b610232565b005b610118610128366004610ee9565b61030d565b61014061013b366004610c51565b610374565b60405161014d91906111f8565b60405180910390f35b610169610164366004610d15565b610389565b60405161014d919061148a565b610118610184366004610cac565b610420565b6101916105a0565b60405161014d91906111cb565b6101406105af565b6101186101b4366004610d5f565b6105c0565b6101c1610795565b60405161014d9190611203565b61019161079b565b6101186101e4366004610ee9565b6107aa565b6101186101f7366004610c51565b6107c2565b61016961020a366004610ed1565b610897565b610191610928565b610118610225366004610c51565b610937565b610191610964565b61023a6105af565b61025f5760405162461bcd60e51b81526004016102569061131a565b60405180910390fd5b6001600160a01b03811660009081526001602052604090205460ff16156102d5576001600160a01b038116600081815260016020526040808220805460ff1916905560028054600019019055517f8ddb5a2efd673581f97000ec107674428dc1ed37e8e7944654e48fb0688114779190a261030a565b6040516001600160a01b038216907f21aa6b3368eceb61c9fc1bdfd2cb6337c87cc1510c1afcc7d5a45371551b43b890600090a25b50565b60048054604051630d9192ef60e01b81526001600160a01b0390911691630d9192ef9161033e918691869101611576565b600060405180830381600087803b15801561035857600080fd5b505af115801561036c573d6000803e3d6000fd5b505050505050565b60016020526000908152604090205460ff1681565b6103916109ce565b60048054604051631bfb9bfb60e21b81526001600160a01b0390911691636fee6fec916103c49188918891889101611220565b60006040518083038186803b1580156103dc57600080fd5b505afa1580156103f0573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f191682016040526104189190810190610d99565b949350505050565b60035460405163d9c4c15360e01b81526001600160a01b039091169063d9c4c15390610452908790879060040161120c565b60206040518083038186803b15801561046a57600080fd5b505afa15801561047e573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052506104a29190810190610c74565b600480546001600160a01b0319166001600160a01b039283161790819055166104dd5760405162461bcd60e51b815260040161025690611297565b60035460405163d9c4c15360e01b81526001600160a01b039091169063d9c4c1539061050f908590859060040161120c565b60206040518083038186803b15801561052757600080fd5b505afa15801561053b573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525061055f9190810190610c74565b600580546001600160a01b0319166001600160a01b0392831617908190551661059a5760405162461bcd60e51b815260040161025690611244565b50505050565b6000546001600160a01b031690565b6000546001600160a01b0316331490565b600080826101a081018035601e19368490030181126105de57600080fd5b9091016020810191503567ffffffffffffffff8111156105fd57600080fd5b6102208102360382131561061057600080fd5b9150600090505b8181101561069357836101a081018035601e193684900301811261063a57600080fd5b9091016020810191503567ffffffffffffffff81111561065957600080fd5b6102208102360382131561066c57600080fd5b8281811061067657fe5b905061022002016101200135830192508080600101915050610617565b5060006106a660c0850160a08601610c51565b60055460405163095ea7b360e01b81529192506001600160a01b038084169263095ea7b3926106db92169087906004016111df565b602060405180830381600087803b1580156106f557600080fd5b505af1158015610709573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525061072d9190810190610c90565b506004805460405163091aa0f360e41b81526001600160a01b03909116916391aa0f309161075d9188910161134f565b600060405180830381600087803b15801561077757600080fd5b505af115801561078b573d6000803e3d6000fd5b5050505050505050565b60025481565b6004546001600160a01b031681565b60405162461bcd60e51b8152600401610256906112ed565b6107ca6105af565b6107e65760405162461bcd60e51b81526004016102569061131a565b6001600160a01b03811660009081526001602052604090205460ff1615610840576040516001600160a01b038216907ff6831fd5f976003f3acfcf6b2784b2f81e3abb43d161884873a310d6beadf38090600090a261030a565b6001600160a01b0381166000818152600160208190526040808320805460ff19168317905560028054909201909155517f3c4dcdfdb789d0f39b8a520a4f83ab2599db1d2ececebe4db2385f360c0d3ce19190a250565b61089f6109ce565b6004805460405163191a607f60e31b81526001600160a01b039091169163c8d303f8916108ce91869101611203565b60006040518083038186803b1580156108e657600080fd5b505afa1580156108fa573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f191682016040526109229190810190610d99565b92915050565b6005546001600160a01b031681565b61093f6105af565b61095b5760405162461bcd60e51b81526004016102569061131a565b61030a81610973565b6003546001600160a01b031681565b600080546040516001600160a01b03808516939216917f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e091a3600080546001600160a01b0319166001600160a01b0392909216919091179055565b604080516101c081018252600080825260208201819052918101829052606081018290526080810182905260a0810182905260c0810182905260e0810182905261010081018290529061012082019081526020016000801916815260200160008152602001600060ff168152602001606081525090565b805161092281611645565b600082601f830112610a60578081fd5b815167ffffffffffffffff811115610a76578182fd5b6020610a858182840201611587565b828152925080830184820161022080850287018401881015610aa657600080fd5b60005b85811015610acd57610abb8984610b4c565b84529284019291810191600101610aa9565b50505050505092915050565b80516109228161165a565b805161092281611668565b805161092281611675565b805161092281611682565b60008083601f840112610b16578182fd5b50813567ffffffffffffffff811115610b2d578182fd5b602083019150836020828501011115610b4557600080fd5b9250929050565b6000610220808385031215610b5f578182fd5b610b6881611587565b91505081518152610b7c8360208401610c46565b602082015260408201516040820152606082015160608201526080820151608082015260a082015160a082015260c082015160c082015260e082015160e0820152610100610bcc84828501610a45565b908201526101208281015190820152610140610bea84828501610aef565b90820152610160828101519082015261018080830151908201526101a080830151908201526101c080830151908201526101e0610c2984828501610ad9565b90820152610200610c3c84848301610ae4565b9082015292915050565b80516109228161168f565b600060208284031215610c62578081fd5b8135610c6d81611645565b9392505050565b600060208284031215610c85578081fd5b8151610c6d81611645565b600060208284031215610ca1578081fd5b8151610c6d8161165a565b60008060008060408587031215610cc1578283fd5b843567ffffffffffffffff80821115610cd8578485fd5b610ce488838901610b05565b90965094506020870135915080821115610cfc578384fd5b50610d0987828801610b05565b95989497509550505050565b600080600060408486031215610d29578081fd5b833567ffffffffffffffff811115610d3f578182fd5b610d4b86828701610b05565b909790965060209590950135949350505050565b600060208284031215610d70578081fd5b813567ffffffffffffffff811115610d86578182fd5b8083016101c08186031215610418578283fd5b600060208284031215610daa578081fd5b815167ffffffffffffffff80821115610dc1578283fd5b6101c0918401808603831315610dd5578384fd5b610dde83611587565b81518152610def8760208401610a45565b6020820152610e018760408401610a45565b6040820152610e138760608401610a45565b606082015260808201516080820152610e2f8760a08401610a45565b60a082015260c082015160c082015260e082015160e08201526101009350610e5987858401610a45565b848201526101209350610e6e87858401610afa565b938101939093526101408181015190840152610160808201519084015261018092610e9b87858401610c46565b848201526101a093508382015183811115610eb4578586fd5b610ec088828501610a50565b948201949094529695505050505050565b600060208284031215610ee2578081fd5b5035919050565b60008060408385031215610efb578182fd5b823591506020830135610f0d8161168f565b809150509250929050565b6001600160a01b03169052565b600082845260208401935081815b848110156110555781358652610f4c6020830183611638565b610f5960208801826111c4565b5060408201356040870152606082013560608701526080820135608087015260a082013560a087015260c082013560c087015260e082013560e0870152610100610fa5818401846115ae565b610fb182890182610f18565b50506101208281013590870152610140610fcd8184018461161e565b610fd982890182611186565b5050610160828101359087015261018080830135908701526101a080830135908701526101c080830135908701526101e061101681840184611604565b61102282890182611172565b505061020061103381840184611611565b61103f82890182611178565b5050610220958601959190910190600101610f33565b5093949350505050565b6000815180845260208401935060208301825b8281101561105557815180518752602081015161109260208901826111c4565b5060408101516040880152606081015160608801526080810151608088015260a081015160a088015260c081015160c088015260e081015160e0880152610100808201516110e2828a0182610f18565b5050610120818101519088015261014080820151611102828a0182611186565b5050610160818101519088015261018080820151908801526101a080820151908801526101c080820151908801526101e080820151611143828a0182611172565b505061020080820151611158828a0182611178565b505050610220959095019460209190910190600101611072565b15159052565b6004811061118257fe5b9052565b6009811061118257fe5b6003811061118257fe5b60008284528282602086013780602084860101526020601f19601f85011685010190509392505050565b60ff169052565b6001600160a01b0391909116815260200190565b6001600160a01b03929092168252602082015260400190565b901515815260200190565b90815260200190565b60006020825261041860208301848661119a565b60006040825261123460408301858761119a565b9050826020830152949350505050565b60208082526033908201527f436f756c64206e6f742066696e642046756e64696e6720636f6e7472616374206040820152726164647265737320696e20726567697374727960681b606082015260800190565b60208082526036908201527f436f756c64206e6f742066696e642050757263686173696e6720636f6e7472616040820152756374206164647265737320696e20726567697374727960501b606082015260800190565b602080825260139082015272139bdd081a5b5c1b195b595b9d1959081e595d606a1b604082015260600190565b6020808252818101527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e6572604082015260600190565b6000602082528235602083015261136960208401846115ae565b6113766040840182610f18565b5061138460408401846115ae565b6113916060840182610f18565b5061139f60608401846115ae565b6113ac6080840182610f18565b50608083013560a08301526113c460a08401846115ae565b6113d160c0840182610f18565b5060c083013560e083015261010060e0840135818401526113f4818501856115ae565b610120915061140582850182610f18565b506114128185018561162b565b610140915061142382850182611190565b506101608185013581850152610180915080850135828501525061144981850185611638565b6101a0915061145a828501826111c4565b50611467818501856115bb565b6101c0925082838601526114806101e086018284610f25565b9695505050505050565b6000602082528251602083015260208301516114a96040840182610f18565b5060408301516114bc6060840182610f18565b5060608301516114cf6080840182610f18565b50608083015160a083015260a08301516114ec60c0840182610f18565b5060c083015160e083015260e083015161010081818501528085015191505061012061151a81850183610f18565b840151905061014061152e84820183611190565b840151610160848101919091528401516101808085019190915284015190506101a061155c818501836111c4565b8401516101c08481015290506104186101e084018261105f565b91825260ff16602082015260400190565b60405181810167ffffffffffffffff811182821017156115a657600080fd5b604052919050565b60008235610c6d81611645565b6000808335601e198436030181126115d1578283fd5b830160208101925035905067ffffffffffffffff8111156115f157600080fd5b61022081023603831315610b4557600080fd5b60008235610c6d8161165a565b60008235610c6d81611668565b60008235610c6d81611675565b60008235610c6d81611682565b60008235610c6d8161168f565b6001600160a01b038116811461030a57600080fd5b801515811461030a57600080fd5b6004811061030a57600080fd5b6009811061030a57600080fd5b6003811061030a57600080fd5b60ff8116811461030a57600080fdfea2646970667358221220a592b2bc73f67cefa100a7dccfd3f9aa73363d3f7c8ae93b057c830a9f7d5aa864736f6c63430006010033";
        public WalletBuyerDeploymentBase() : base(BYTECODE) { }
        public WalletBuyerDeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("address", "contractAddressOfRegistry", 1)]
        public virtual string ContractAddressOfRegistry { get; set; }
    }

    public partial class BoundAddressCountFunction : BoundAddressCountFunctionBase { }

    [Function("BoundAddressCount", "int256")]
    public class BoundAddressCountFunctionBase : FunctionMessage
    {

    }

    public partial class BoundAddressesFunction : BoundAddressesFunctionBase { }

    [Function("BoundAddresses", "bool")]
    public class BoundAddressesFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class AddressRegistryFunction : AddressRegistryFunctionBase { }

    [Function("addressRegistry", "address")]
    public class AddressRegistryFunctionBase : FunctionMessage
    {

    }

    public partial class BindAddressFunction : BindAddressFunctionBase { }

    [Function("bindAddress")]
    public class BindAddressFunctionBase : FunctionMessage
    {
        [Parameter("address", "a", 1)]
        public virtual string A { get; set; }
    }

    public partial class CancelPurchaseOrderItemFunction : CancelPurchaseOrderItemFunctionBase { }

    [Function("cancelPurchaseOrderItem")]
    public class CancelPurchaseOrderItemFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "poNumber", 1)]
        public virtual BigInteger PoNumber { get; set; }
        [Parameter("uint8", "poItemNumber", 2)]
        public virtual byte PoItemNumber { get; set; }
    }

    public partial class ConfigureFunction : ConfigureFunctionBase { }

    [Function("configure")]
    public class ConfigureFunctionBase : FunctionMessage
    {
        [Parameter("string", "nameOfPurchasing", 1)]
        public virtual string NameOfPurchasing { get; set; }
        [Parameter("string", "nameOfFunding", 2)]
        public virtual string NameOfFunding { get; set; }
    }

    public partial class CreatePurchaseOrderFunction : CreatePurchaseOrderFunctionBase { }

    [Function("createPurchaseOrder")]
    public class CreatePurchaseOrderFunctionBase : FunctionMessage
    {
        [Parameter("tuple", "po", 1)]
        public virtual Po Po { get; set; }
    }

    public partial class FundingFunction : FundingFunctionBase { }

    [Function("funding", "address")]
    public class FundingFunctionBase : FunctionMessage
    {

    }

    public partial class GetPoFunction : GetPoFunctionBase { }

    [Function("getPo", typeof(GetPoOutputDTO))]
    public class GetPoFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "poNumber", 1)]
        public virtual BigInteger PoNumber { get; set; }
    }

    public partial class GetPoBySellerAndQuoteFunction : GetPoBySellerAndQuoteFunctionBase { }

    [Function("getPoBySellerAndQuote", typeof(GetPoBySellerAndQuoteOutputDTO))]
    public class GetPoBySellerAndQuoteFunctionBase : FunctionMessage
    {
        [Parameter("string", "sellerIdString", 1)]
        public virtual string SellerIdString { get; set; }
        [Parameter("uint256", "quoteId", 2)]
        public virtual BigInteger QuoteId { get; set; }
    }

    public partial class IsOwnerFunction : IsOwnerFunctionBase { }

    [Function("isOwner", "bool")]
    public class IsOwnerFunctionBase : FunctionMessage
    {

    }

    public partial class OwnerFunction : OwnerFunctionBase { }

    [Function("owner", "address")]
    public class OwnerFunctionBase : FunctionMessage
    {

    }

    public partial class PurchasingFunction : PurchasingFunctionBase { }

    [Function("purchasing", "address")]
    public class PurchasingFunctionBase : FunctionMessage
    {

    }

    public partial class SetPoItemGoodsReceivedFunction : SetPoItemGoodsReceivedFunctionBase { }

    [Function("setPoItemGoodsReceived")]
    public class SetPoItemGoodsReceivedFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "poNumber", 1)]
        public virtual BigInteger PoNumber { get; set; }
        [Parameter("uint8", "poItemNumber", 2)]
        public virtual byte PoItemNumber { get; set; }
    }

    public partial class TransferOwnershipFunction : TransferOwnershipFunctionBase { }

    [Function("transferOwnership")]
    public class TransferOwnershipFunctionBase : FunctionMessage
    {
        [Parameter("address", "newOwner", 1)]
        public virtual string NewOwner { get; set; }
    }

    public partial class UnBindAddressFunction : UnBindAddressFunctionBase { }

    [Function("unBindAddress")]
    public class UnBindAddressFunctionBase : FunctionMessage
    {
        [Parameter("address", "a", 1)]
        public virtual string A { get; set; }
    }

    public partial class AddressAlreadyBoundEventDTO : AddressAlreadyBoundEventDTOBase { }

    [Event("AddressAlreadyBound")]
    public class AddressAlreadyBoundEventDTOBase : IEventDTO
    {
        [Parameter("address", "a", 1, true )]
        public virtual string A { get; set; }
    }

    public partial class AddressAlreadyUnBoundEventDTO : AddressAlreadyUnBoundEventDTOBase { }

    [Event("AddressAlreadyUnBound")]
    public class AddressAlreadyUnBoundEventDTOBase : IEventDTO
    {
        [Parameter("address", "a", 1, true )]
        public virtual string A { get; set; }
    }

    public partial class AddressBoundEventDTO : AddressBoundEventDTOBase { }

    [Event("AddressBound")]
    public class AddressBoundEventDTOBase : IEventDTO
    {
        [Parameter("address", "a", 1, true )]
        public virtual string A { get; set; }
    }

    public partial class AddressUnBoundEventDTO : AddressUnBoundEventDTOBase { }

    [Event("AddressUnBound")]
    public class AddressUnBoundEventDTOBase : IEventDTO
    {
        [Parameter("address", "a", 1, true )]
        public virtual string A { get; set; }
    }

    public partial class OwnershipTransferredEventDTO : OwnershipTransferredEventDTOBase { }

    [Event("OwnershipTransferred")]
    public class OwnershipTransferredEventDTOBase : IEventDTO
    {
        [Parameter("address", "previousOwner", 1, true )]
        public virtual string PreviousOwner { get; set; }
        [Parameter("address", "newOwner", 2, true )]
        public virtual string NewOwner { get; set; }
    }

    public partial class BoundAddressCountOutputDTO : BoundAddressCountOutputDTOBase { }

    [FunctionOutput]
    public class BoundAddressCountOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("int256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class BoundAddressesOutputDTO : BoundAddressesOutputDTOBase { }

    [FunctionOutput]
    public class BoundAddressesOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class AddressRegistryOutputDTO : AddressRegistryOutputDTOBase { }

    [FunctionOutput]
    public class AddressRegistryOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }









    public partial class FundingOutputDTO : FundingOutputDTOBase { }

    [FunctionOutput]
    public class FundingOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class GetPoOutputDTO : GetPoOutputDTOBase { }

    [FunctionOutput]
    public class GetPoOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple", "po", 1)]
        public virtual Po Po { get; set; }
    }

    public partial class GetPoBySellerAndQuoteOutputDTO : GetPoBySellerAndQuoteOutputDTOBase { }

    [FunctionOutput]
    public class GetPoBySellerAndQuoteOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple", "po", 1)]
        public virtual Po Po { get; set; }
    }

    public partial class IsOwnerOutputDTO : IsOwnerOutputDTOBase { }

    [FunctionOutput]
    public class IsOwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class OwnerOutputDTO : OwnerOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class PurchasingOutputDTO : PurchasingOutputDTOBase { }

    [FunctionOutput]
    public class PurchasingOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }






}
