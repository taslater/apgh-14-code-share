import os

root_dir = '../../'

project_dirs = [
    f'{root_dir}{s}/Projects/' for s in os.listdir(root_dir) if s[:4] == 'Week']

for project_dir in project_dirs:
    for f_name in os.listdir(project_dir):
        print(f_name)

# groups_path = './group_history.md'

# with open(groups_path, 'r') as f:
#     lines = f.readlines()

# project_name = None
# group_int = 0
# person_name = None

# result_dict = dict()

# for line in lines:
#     if line[:3] == '## ':
#         project_name = line[:-1].replace('#', '').strip()
#         result_dict[project_name] = dict()
#     elif line[:4] == '### ':
#         group_int = int(line[:-1].replace('#', '').strip().split(' ')[1])
#         result_dict[project_name][group_int] = []
#     elif line[:2] == '* ':
#         person_name = line[2:].strip()
#         result_dict[project_name][group_int].append(person_name)
