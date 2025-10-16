using arvores;

//declaraçao de variavel Tree do tipo Tree , onde Tree<Int> agora é de inteiros

Tree<int> tree = new Tree<int>();

tree.Root = new TreeNode<int>();

// root é a raiz da arvore, instanciado com se tipo Treenode, onde Treenode<int> é um node que armazena um valor inteiro

tree.Root.Data = 100;

tree.Root.Children =
    new List<TreeNode<int>>

    // Children é uma lista de nodes filhos do node atual, que no caso é a raiz
    
    {
    new TreeNode<int>() { Data = 50, Parent = tree.Root },
    new TreeNode<int>() { Data = 1, Parent = tree.Root },
    new TreeNode<int>() { Data = 150, Parent = tree.Root }
    };

tree.Root.Children[2].Children = new List<TreeNode<int>>()
{
    new TreeNode<int>() { Data = 30, Parent = tree.Root.Children[2] },
};
