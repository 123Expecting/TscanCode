--ǰ�����ʡ��
function Demo:setData(idx, data)
	self.chatBg.setFlipX(idx % 2 == 0)
	if data then
		local person = nil
		if data.type == 1 then
			person = "����"
		elseif data.type == 2 then
			person = "����"
		elseif data.type == 3 then
			person = "��ĸ"
		end
		--person ��ʼֵΪnil, ��ȱ��else��֧
		self.ToLabel:setString("������"..person.."˵")
	end
end