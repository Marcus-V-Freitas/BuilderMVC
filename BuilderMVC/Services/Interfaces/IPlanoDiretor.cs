namespace BuilderMVC.Services.Interfaces
{
    public interface IPlanoDiretor
    {
        void SetPlanoBuilder(IPlanoBuilder builder);

        void BuildPlanoBasico();

        void BuildPlanoEnterprise();
    }
}