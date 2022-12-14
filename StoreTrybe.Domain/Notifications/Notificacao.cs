namespace StoreTrybe.Domain.Notifications
{
    public abstract class Notificacao
    {
        private readonly Dictionary<string, string> _notificacoes;

        public bool EntidadeValida { get; private set; }
        public IReadOnlyDictionary<string, string> Notificacoes => _notificacoes;

        public Notificacao()
        {
            EntidadeValida = true;
            _notificacoes = new Dictionary<string, string>();
        }

        public void VerificarEntidade() =>
            EntidadeValida = Notificacoes.Count == 0;

        public void AdicionarNotificacao(string valor, string mensagem) =>
            _notificacoes.Add(valor, mensagem);
    }
}