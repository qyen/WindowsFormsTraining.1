# Windows Forms Traning #1 �Ƃ肠��������Ă݂�

�h��Ԃ̃������A�v���ł��B

## �菇


1. �V�����v���W�F�N�g��Windows�t�H�[���A�v���P�[�V������I��ŐV�K�쐬
1. �c�[���{�b�N�X���� `���j���[�ƃc�[���o�[>MenuStrip`���_�u���N���b�N
1. �c�[���{�N�X���� `�R�����R���g���[��>TextBox`���_�u���N���b�N
1. �t�H�[�����TextBox��I��Ńv���p�e�B����ȉ���ݒ�
    - Multiline : True
    - Dock : Fill
1. MenuStrip��I���`�����֓���`�̂Ƃ���� `File`�ƋL��
1. 5�ō쐬����File ��I��ł��̉��ɏo�Ă���`�����֓���`�Ɉȉ���ǉ�
   - Open
   - Save
   - Close
1. 6�ō쐬�������j���[��1�I��Ńv���p�e�B����`ShortcutKeys`���ȉ��ɐݒ�
   - Open : Ctrl+O
   - Save : Ctrl+S
1. �c�[���{�N�X���� `�_�C�A���O>OpenFileDialog`���_�u���N���b�N
1. 8�ō쐬���ꂽopenFileDialog1��I��Ńv���p�e�B�Ɉȉ���ݒ�
    - Filter : Text Files (.txt)|*.txt|All Files (*.*)|*.*
1. �c�[���{�N�X���� `�_�C�A���O>SaveFileDialog`���_�u���N���b�N
1. 8�ō쐬���ꂽsaveFileDialog1��I��Ńv���p�e�B�Ɉȉ���ݒ�
    - Filter : Text Files (.txt)|*.txt|All Files (*.*)|*.*
1. 6�ō쐬�������j���[��Open���_�u���N���b�N
1. �_�u���N���b�N���ĊJ�����G�f�B�^��`openToolStripMenuItem_Click()`�̓��e�Ɉȉ����R�s�y

```C#
if (openFileDialog1.ShowDialog() == DialogResult.OK) {
    string selectedFilename = openFileDialog1.FileName;
    using (var sreader = new System.IO.StreamReader(selectedFilename)) {
        this.textBox1.Text = sreader.ReadToEnd();
    }
}
```

14. 6�ō쐬�������j���[��Save���_�u���N���b�N
1. �_�u���N���b�N���ĊJ�����G�f�B�^��`saveToolStripMenuItem_Click()`�̓��e�Ɉȉ����R�s�y

```C#
if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
    string selectedFilename = this.saveFileDialog1.FileName;
    using (var swriter = new System.IO.StreamWriter(selectedFilename)) {
        swriter.Write(this.textBox1.Text);
    }
}
```
16. 6�ō쐬�������j���[��Close���_�u���N���b�N
1. �_�u���N���b�N���ĊJ�����G�f�B�^��`closeToolStripMenuItem_Click()`�̓��e�Ɉȉ����R�s�y
```C#
this.Close();
```

18. F5�L�[�������Ď��s

## �h����

1. �e�L�X�g�{�b�N�X�̃t�H���g�����₷���t�H���g�ɕς��悤
2. �t�H���g�����[�U�[���ύX�ł���悤�ɂ��悤
   - �q���g:FontDialog
1. ���O�����ĕۑ��Ə㏑���ۑ��@�\����낤


## �R�[�h���

������B
