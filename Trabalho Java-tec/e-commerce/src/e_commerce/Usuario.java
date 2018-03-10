package e_commerce;

import java.util.Date;

public class Usuario {
	private String nome;
	private int usuario_id;
	private String login;
	private String senha;
	private String e_mail;
	private String endere�o;
	private int cpf;
	private Date dataDeNascimento;
	
	public String getNome() {
		return nome;
	}
	public void setNome(String nome) {
		this.nome = nome;
	}
	public int getUsuario_id() {
		return usuario_id;
	}
	public void setUsuario_id(int usuario_id) {
		this.usuario_id = usuario_id;
	}
	public String getLogin() {
		return login;
	}
	public void setLogin(String login) {
		this.login = login;
	}
	public String getSenha() {
		return senha;
	}
	public void setSenha(String senha) {
		this.senha = senha;
	}
	public String getE_mail() {
		return e_mail;
	}
	public void setE_mail(String e_mail) {
		this.e_mail = e_mail;
	}
	public String getEndere�o() {
		return endere�o;
	}
	public void setEndere�o(String endere�o) {
		this.endere�o = endere�o;
	}
	public int getCpf() {
		return cpf;
	}
	public void setCpf(int cpf) {
		this.cpf = cpf;
	}
	public Date getDataDeNascimento() {
		return dataDeNascimento;
	}
	public void setDataDeNascimento(Date dataDeNascimento) {
		this.dataDeNascimento = dataDeNascimento;
	}
	
	public Usuario(String nome, int usuario_id, String login, String senha,
			String e_mail, String endere�o, int cpf, Date dataDeNascimento) {
		super();
		this.nome = nome;
		this.usuario_id = usuario_id;
		this.login = login;
		this.senha = senha;
		this.e_mail = e_mail;
		this.endere�o = endere�o;
		this.cpf = cpf;
		this.dataDeNascimento = dataDeNascimento;
	}
	
	
	
	

	
}